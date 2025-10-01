# Omaha Hand Evaluator Implementation Plan

## Overview
Add support for evaluating 4, 5, and 6 card Omaha poker hands. Omaha uses the same hand rankings as Texas Hold'em, but requires exactly 2 cards from the player's hand and exactly 3 cards from the board.

## Current Codebase Understanding

### How Hold'em Evaluator Works
1. **Card Representation**: Cards are integers where `card >> 2` gives rank (0-12 for 2-A)
2. **Evaluation Strategy**: Two paths based on flush detection
   - **Flush Path**: Uses color bits to detect 5+ same suit, looks up in FlushHashtable
   - **Non-Flush Path**: Creates quinary (base-5) distribution of ranks, hashes and looks up ranking
3. **Hashtable Lookups**: Pre-computed rankings for all possible 5, 6, and 7 card combinations
4. **Lower ranking = better hand**

### Key Components
- `HoldemHandEvaluator`: Public API class with static methods
- `RankingEvaluator`: Internal evaluation logic for 5/6/7 cards
- `FlushHashHelper`: Flush detection helpers
- `QuinaryHashHelper`: Quinary hash computation
- Hashtable classes: Pre-computed rankings for fast lookups

## Omaha-Specific Requirements

### Rules
- Player has 4, 5, or 6 hole cards
- Board has 3, 4, or 5 community cards (flop/turn/river)
- **Must use exactly 2 cards from hand**
- **Must use exactly 3 cards from board**
- Example: 4 clubs on board + 1 club in hand ≠ flush

### Input Validation
- Hole cards: 4-6 cards
- Board cards: 3-5 cards
- Total: 7-11 cards
- No duplicate cards between hand and board

## Implementation Strategy

### Approach: Combination Generation + Existing Evaluator
Since we already have a highly optimized 5-card evaluator, we can:
1. Generate all combinations of 2 cards from the Omaha hand
2. Generate all combinations of 3 cards from the board
3. Evaluate each 5-card combination using `RankingEvaluator.Evaluate5CardRating`
4. Return the best (lowest) ranking

**Complexity Analysis:**
- Max combinations: C(6,2) × C(5,3) = 15 × 10 = 150 evaluations
- Each evaluation is extremely fast (few CPU cycles via hashtable lookup)
- Total time: negligible, likely microseconds

### Alternative Approaches Considered
1. **Build Omaha-specific hashtables**: Too complex, would require massive pre-computation
2. **Modify existing evaluator**: Would break existing functionality
3. **Use 7-card evaluator on all cards**: Violates "exactly 2 from hand, 3 from board" rule

**Chosen approach is best**: Leverages existing fast evaluator, simple to implement, easy to test

## Implementation Plan

### 1. Create Helper Class: `CombinationHelper`
**File**: `HoldemPoker.Evaluator/Helpers/CombinationHelper.cs`

**Purpose**: Generate combinations of cards

**Methods**:
```csharp
internal static IEnumerable<Card[]> GetCombinations(Card[] cards, int count)
```
Generate all combinations of `count` cards from `cards` array.

**Alternative design** - Specialized methods:
```csharp
internal static IEnumerable<(Card, Card)> GetTwoCardCombinations(Card[] cards)
internal static IEnumerable<(Card, Card, Card)> GetThreeCardCombinations(Card[] cards)
```
These could be more efficient and type-safe, but less general.

**Decision**: Start with general `GetCombinations` method for flexibility. Can optimize later if needed.

**Implementation Notes**:
- Make internal static class (consistent with other helpers)
- Optimize for small counts (we only need C(n,2) and C(n,3))
- Use iterative index-based approach with nested loops for efficiency
- For C(n,2): Two nested loops, yield return new array with 2 cards
- For C(n,3): Three nested loops, yield return new array with 3 cards
- Could use general recursive algorithm, but explicit loops are clearer and faster for small k
- Use `yield return` for lazy evaluation (memory efficient)

### 2. Create Omaha Evaluator Class: `OmahaHandEvaluator`
**File**: `HoldemPoker.Evaluator/OmahaHandEvaluator.cs`

**Purpose**: Public API for Omaha hand evaluation

**Methods**:
```csharp
public static int GetHandRanking(Card[] holeCards, Card[] boardCards)
public static string GetHandDescription(Card[] holeCards, Card[] boardCards)
public static string GetHandDescription(int ranking)
public static PokerHandCategory GetHandCategory(Card[] holeCards, Card[] boardCards)
public static PokerHandCategory GetHandCategory(int ranking)
```

**Implementation**:
- Mirror `HoldemHandEvaluator` API for consistency
- Validate inputs:
  - holeCards: null check, must be 4-6 cards (throw ArgumentNullException or ArgumentException)
  - boardCards: null check, must be 3-5 cards (throw ArgumentNullException or ArgumentException)
  - No duplicate cards within holeCards (throw ArgumentException: "Duplicate cards in hole cards")
  - No duplicate cards within boardCards (throw ArgumentException: "Duplicate cards in board")
  - No duplicate cards between holeCards and boardCards (throw ArgumentException: "Duplicate cards between hole cards and board")
- Generate all 2-card combinations from holeCards using CombinationHelper
- Generate all 3-card combinations from boardCards using CombinationHelper
- Initialize bestRanking to int.MaxValue
- For each 2-card hand combination:
  - For each 3-card board combination:
    - Combine into 5-card array [hand[0], hand[1], board[0], board[1], board[2]]
    - Call `RankingEvaluator.Evaluate5CardRating`
    - If ranking < bestRanking, update bestRanking
    - **Optimization**: If bestRanking == 1 (Royal Flush), break early (can't get better)
- Return bestRanking
- For GetHandCategory(int) and GetHandDescription(int): Delegate directly to HoldemHandEvaluator
- For GetHandCategory(cards) and GetHandDescription(cards): Call GetHandRanking first, then delegate

**Design Decision - Category/Description Methods**:
- Option 1: Reuse `HoldemHandEvaluator.GetHandCategory(int)` - simple but creates dependency
- Option 2: Extract shared logic to common helper class
- Option 3: Duplicate the category logic
- **Chosen**: Option 1 for simplicity, ranking-to-category is universal

### 3. Create Internal Validation Helper (Optional)
**File**: `HoldemPoker.Evaluator/Helpers/CardValidationHelper.cs`

**Purpose**: Centralize card validation logic

**Methods**:
- `void ValidateNoDuplicates(Card[] cards)`: Check no duplicate cards in array
- `void ValidateNoDuplicates(Card[] cards1, Card[] cards2)`: Check no duplicates between arrays

**Implementation Notes**:
- Use HashSet for O(n) duplicate detection
- Throw ArgumentException with descriptive message
- Could be useful for future validation needs

### 4. Update Public API Surface
Since we're adding a new evaluator, consider:
- Keep `OmahaHandEvaluator` as separate class (cleaner separation)
- Document Omaha-specific rules in XML comments
- Add usage examples in class documentation

## File Structure

```
HoldemPoker.Evaluator/
├── Helpers/
│   ├── CombinationHelper.cs (NEW)
│   └── CardValidationHelper.cs (NEW, optional)
├── OmahaHandEvaluator.cs (NEW)
└── (existing files unchanged)
```

## Testing Strategy

### Unit Tests
**File**: `HoldemPoker.Evaluator.Tests/OmahaHandEvaluatorTests.cs`

#### Test Categories

**1. Basic Hand Rankings** (test all 10 hand types):
- Royal Flush
- Straight Flush
- Four of a Kind
- Full House
- Flush
- Straight
- Three of a Kind
- Two Pair
- One Pair
- High Card

**2. Omaha Rule Enforcement**:
- Hand with 1 club + 4 clubs on board = NOT a flush
- Must use exactly 2 from hand:
  - Test case where board has better 5 cards but player must use 2 from hand
  - Test case where hand has 4 of a kind but can only use 2
- Must use exactly 3 from board:
  - Test with varying board sizes (3, 4, 5 cards)

**3. Edge Cases**:
- Four of a kind in hand (can only use 2) - should be pair or two pair
- Four of a kind on board (must use 3) - can make trips or quads if hand has matching card
- Straight/flush possibilities that don't work due to 2-from-hand rule
- All combinations of hand sizes (4, 5, 6) with board sizes (3, 4, 5)

**4. Input Validation**:
- Null checks (holeCards, boardCards)
- Invalid card counts (too few, too many)
- Duplicate cards in hand
- Duplicate cards on board
- Duplicate cards between hand and board

**5. Ranking Consistency**:
- Better hands should have lower rankings
- Same hand composition should give same ranking
- Compare Omaha rankings with Hold'em rankings for equivalent final hands

**6. Combination Generation Tests** (for CombinationHelper):
- C(4,2) = 6 combinations
- C(5,2) = 10 combinations
- C(6,2) = 15 combinations
- C(3,3) = 1 combination
- C(4,3) = 4 combinations
- C(5,3) = 10 combinations
- Verify no duplicate combinations
- Verify all combinations generated

### Test Data Strategy
- Use string notation for card input: "AhKhQhJhTh" for easy reading
- Create helper method to parse card strings (similar to existing tests)
- Create test data provider class for common scenarios

### Edge Case Examples

**Example 1: Four of a kind in hand (can only use 2)**
```
Hand: AsAhAdAc (4 aces)
Board: KsQsJs (K-Q-J)
Must use exactly 2 aces from hand.
Best: AsAh + KsQsJs = Pair of Aces with K-Q-J kickers
Category: OnePair
Note: Even though we have 4 aces, we can only use 2, making it just a pair.
```

**Example 1b: Four of a kind achievable**
```
Hand: AsAhKdQd
Board: AdAcKs
Must use 2 from hand, 3 from board.
Option 1: AsAh + AdAcKs = Four Aces (4 aces total, K kicker)
Option 2: KdQd + AdAcKs = Full House (Aces over Kings)
Best: Four Aces
Category: FourOfAKind
```

**Example 2: Flush that doesn't work vs one that does**
```
Hand: Ah3d4d5d (only one heart)
Board: 2h6h7h8h (four hearts)
NOT a flush using Ah + 4 hearts from board (violates rules)
BUT IS a flush using Ah3d + 2h6h7h (2 from hand, 3 from board - both hearts and non-hearts)
Wait, that's wrong too. Let me reconsider:

Hand: Ah3d4d5d (Ah is only heart in hand)
Board: 2h6h7h8h (all hearts)
We need exactly 2 from hand and 3 from board.
If we take Ah3d from hand + 2h6h7h from board = Ah,3d,2h,6h,7h = 4 hearts (flush!)
If we take Ah4d from hand + 2h6h7h from board = Ah,4d,2h,6h,7h = 4 hearts (flush!)

Better example - flush that DOESN'T work:
Hand: Ah2d3d4d (only one heart)
Board: 5s6s7s8s (no hearts)
Cannot make a flush - only 1 heart available

Best example - "dummy flush":
Hand: Ah2h3h4h (four hearts)
Board: 5s6s7s (no hearts)
Cannot make a flush! We can take 2 hearts from hand and 3 non-hearts from board.
Best possible: Ah2h + 5s6s7s = just high card or possible straight
```

**Example 3: Straight combinations**
```
Hand: 9h8s7d6c
Board: 5h4d3c
Possible straights:
- 9h8s + 7h6h5h (NO - no 7h, 6h, 5h on board)
- 9h8s + 5h4d3c = 9,8,5,4,3 (NO - not consecutive)
- 7d6c + 5h4d3c = 7,6,5,4,3 (YES - Seven-high straight)
Best: Seven-high straight

Hand: AhKhQdJd
Board: Ts9s8s
Possible:
- AhKh + Ts9s8s = A,K,T,9,8 (NO - not consecutive)
- QdJd + Ts9s8s = Q,J,T,9,8 (YES - Queen-high straight)
Best: Queen-high straight
```

## Implementation Steps

1. **Implement CombinationHelper**
   - Write combination generation algorithm
   - Test with unit tests to verify correctness

2. **Implement CardValidationHelper** (if using)
   - Write validation methods
   - Test with unit tests

3. **Implement OmahaHandEvaluator**
   - Start with GetHandRanking method
   - Add input validation
   - Implement combination generation and evaluation loop
   - Add GetHandCategory and GetHandDescription wrappers

4. **Write Comprehensive Tests**
   - Start with basic hand rankings
   - Add Omaha-specific rule tests
   - Add edge cases
   - Add input validation tests

5. **Build and Test**
   - Ensure project compiles
   - Run all tests (new and existing)
   - Verify no regressions in Hold'em evaluator

6. **Iterate and Refine**
   - Fix any failing tests
   - Optimize if needed (though performance should be fine)
   - Add more edge cases if discovered during testing

## Optimizations

**Implemented from the start**:
1. **Early termination**: If we find a Royal Flush (ranking = 1), stop searching (can't get better)

**Future optimizations** (if performance becomes an issue, which is unlikely):
1. **Caching**: Cache combination arrays if called repeatedly
2. **Parallel evaluation**: Evaluate combinations in parallel (probably overkill)
3. **Specialized evaluators**: Build Omaha-specific hashtables (massive effort, not worth it)

**Current plan is sufficient**: 150 hashtable lookups is negligible on modern hardware (likely < 1 microsecond total)

## Documentation

### XML Documentation
- Add comprehensive XML comments to all public methods
- Explain Omaha rules clearly
- Provide usage examples

### README Updates
After implementation, could update README.md to mention Omaha support, but this is optional since it's a separate evaluator class.

## Migration/Compatibility

- No changes to existing `HoldemHandEvaluator`
- No breaking changes to existing API
- New functionality is purely additive
- Existing tests should continue to pass unchanged

## Summary

This plan leverages the existing highly-optimized 5-card evaluator to implement Omaha evaluation through combination generation. The approach is simple, correct, and performant. The implementation will be clean, well-tested, and maintain consistency with the existing codebase style.
