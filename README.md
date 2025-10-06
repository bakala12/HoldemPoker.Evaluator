# HoldemPoker.Evaluator
[HoldemPoker.Evaluator](https://github.com/bakala12/HoldemPoker.Evaluator)

## Description
A port of [HenryRLee/PokerHandEvaluator](https://github.com/HenryRLee/PokerHandEvaluator) from C++ to C#.
The code offers very efficient evaluation of poker hands for:
* **Texas Hold'em** - 5 to 7 cards
* **Omaha** (including 5-card and 6-card variants) - 4 to 6 hole cards with 3 to 5 board cards

It uses [HoldemPoker.Cards](https://www.nuget.org/packages/HoldemPoker.Cards/) nuget packages

## Usage
Project is written as a .NET 8 class library. The code is available on [NuGet](https://www.nuget.org/packages/HoldemPoker.Evaluator/).

### Texas Hold'em Evaluation

Evaluating a hand is possible using [HoldemHandEvaluator](HoldemPoker.Evaluator/HoldemHandEvaluator.cs) class methods. It supports following methods:
* GetHandRanking - Gets the integer number informing of how good the hand is. The lower the ranking the better the hand is.
* GetHandCategory - Gets the category of the hand (like Flush or HighCard).
* GetHandDescription - Gets the description of the hand, for example "Royal Flush" Or "Pair of Kings"

Example:
```csharp
using HoldemPoker.Cards;
using HoldemPoker.Evaluator;

// Evaluate a 7-card Hold'em hand
var cards = new Card[]
{
    Card.Parse("Ah"), Card.Parse("Kh"),  // Player's hole cards
    Card.Parse("Qh"), Card.Parse("Jh"), Card.Parse("Th"),  // Flop + Turn
    Card.Parse("9s"), Card.Parse("8s")   // River
};

int ranking = HoldemHandEvaluator.GetHandRanking(cards);
PokerHandCategory category = HoldemHandEvaluator.GetHandCategory(cards);
string description = HoldemHandEvaluator.GetHandDescription(cards);

Console.WriteLine($"Ranking: {ranking}");        // Lower is better
Console.WriteLine($"Category: {category}");      // RoyalFlush
Console.WriteLine($"Description: {description}"); // "Royal Flush"
```

### Omaha Evaluation

Evaluating an Omaha hand is possible using [OmahaHandEvaluator](HoldemPoker.Evaluator/OmahaHandEvaluator.cs) class methods. It supports the same methods as the Hold'em evaluator:
* GetHandRanking - Gets the integer number informing of how good the hand is. The lower the ranking the better the hand is.
* GetHandCategory - Gets the category of the hand (like Flush or HighCard).
* GetHandDescription - Gets the description of the hand, for example "Royal Flush" Or "Pair of Kings"

**Important:** Omaha rules require using exactly 2 cards from the player's hole cards and exactly 3 cards from the board. For example, having 1 club in your hand and 4 clubs on the board does NOT make a flush.

Example:
```csharp
using HoldemPoker.Cards;
using HoldemPoker.Evaluator;

// Evaluate a 4-card Omaha hand with a 5-card board
var holeCards = new Card[]
{
    Card.Parse("Ah"), Card.Parse("Kh"),
    Card.Parse("Qd"), Card.Parse("Jd")
};

var boardCards = new Card[]
{
    Card.Parse("Qh"), Card.Parse("Jh"), Card.Parse("Th"),  // Flop
    Card.Parse("9s"),                                       // Turn
    Card.Parse("8s")                                        // River
};

int ranking = OmahaHandEvaluator.GetHandRanking(holeCards, boardCards);
PokerHandCategory category = OmahaHandEvaluator.GetHandCategory(holeCards, boardCards);
string description = OmahaHandEvaluator.GetHandDescription(holeCards, boardCards);

Console.WriteLine($"Ranking: {ranking}");        // Lower is better
Console.WriteLine($"Category: {category}");      // RoyalFlush (AhKh from hand + QhJhTh from board)
Console.WriteLine($"Description: {description}"); // "Royal Flush"
```

#### Omaha Variants Supported
* **Omaha (PLO)** - 4 hole cards
* **5-Card Omaha** - 5 hole cards
* **6-Card Omaha** - 6 hole cards

All variants work with 3 (flop only), 4 (flop + turn), or 5 (flop + turn + river) board cards.

## Implementation

### Texas Hold'em Algorithm
Efficient evaluation of Texas Hold'em Poker hand may be tricky task. This implementation strongly use hashtables that caches and speeds up the access to data very significantly.
Evaluating single poker hand using this implementation only lasts a few processor cycles.

Original documentation of the algorithm is available [here](https://github.com/HenryRLee/PokerHandEvaluator/blob/develop/Documentation/Algorithm.md).

#### Evaluating Flushes
First step is determining if the hand is a flush (or straight flush).

If there is at least 5 cards in the same color the hand is a flush or straight flush. Notice that if there is 5 cards in the same color, there is no possibility for any better hand (like full house or four of a kind).
Cards in flush color are now converted to `flush cards hash` which is 13-bits number in which set bits corresponds to type of cards in the flush color.

Based on the 13-bits value the ranking of the hand is given (using [FlushHashtable](HoldemPoker.Evaluator/Hashtables/FlushHashtable.cs))

#### Evaluating non-flush hands
If the hand is not a flush, only card types matters. This means we count the number of each card types (number of aces, kings, etc.) forming 13-digits quinary (base 5) number. Each digit represents number of card of given type (from 0 to 4).

Next step is converting this quinary number to a `quinary hash` that will allow to get hand ranking from proper hashtable ([Hashtable5](HoldemPoker.Evaluator/Hashtables/Hashtable5.cs), [Hashtable6](HoldemPoker.Evaluator/Hashtables/Hashtable6.cs) or [Hashtable7](HoldemPoker.Evaluator/Hashtables/Hashtable7.cs)).
Details about creation of `quinary hash` can be found in [original algorithm documentation](https://github.com/HenryRLee/PokerHandEvaluator/blob/develop/Documentation/Algorithm.md#chapter-3-hash-for-a-restricted-quinary) by [HenryRLee](https://github.com/HenryRLee).

### Omaha Algorithm
The Omaha evaluator enforces the rule that exactly 2 cards must come from the player's hole cards and exactly 3 cards must come from the board.

The implementation:
1. Generates all possible 2-card combinations from the hole cards
2. Generates all possible 3-card combinations from the board cards
3. Evaluates each resulting 5-card hand using the existing optimized Hold'em 5-card evaluator
4. Returns the best (lowest) ranking found

For a typical 4-card Omaha hand with a 5-card board, this means evaluating C(4,2) × C(5,3) = 6 × 10 = 60 combinations. Each evaluation is extremely fast (hashtable lookup), making the entire process complete in microseconds.

The evaluator includes early termination optimization: if a Royal Flush is found (ranking = 1), it immediately returns since no better hand is possible.

## Testing
See [unit tests](HoldemPoker.Evaluator.Tests)

## License
The project is licensed under the Apache 2.0 License - see the [LICENSE](LICENSE) file for details.

## Author
Written and tested by Mateusz Bąkała (bakala12@o2.pl)