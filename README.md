# HoldemPoker.Evaluator
[HoldemPoker.Evaluator](https://github.com/bakala12/HoldemPoker.Evaluator)

## Description
A port of [HenryRLee/PokerHandEvaluator](https://github.com/HenryRLee/PokerHandEvaluator) from C++ to C#.
The code offers very efficient evaluation of Texas Hold'em Poker hand with 5 to 7 cards.
 
## Usage
Project is written as a .NET 8 class library. The code is available on [NuGet](https://www.nuget.org/packages/HoldemPoker.Evaluator/).

Evaluating a hand is possible using [HoldemHandEvaluator](HoldemPoker.Evaluator/HoldemHandEvaluator.cs) class methods. It supports following methods:
* GetHandRanking - Gets the integer number informing of how good the hand is. The lower the ranking the better the hand is.
* GetHandCategory - Gets the category of the hand (like Flush or HighCard).
* GetHandDescription - Gets the description of the hand, for example "Royal Flush" Or "Pair of Kings"

## Implementation
Efficient evaluation of Texas Hold'em Poker hand may be tricky task. This implementation strongly use hashtables that caches and speeds up the access to data very significantly.
Evaluating single poker hand using this implementation only lasts a few processor cycles.

Original documentation of the algorithm is available [here](https://github.com/HenryRLee/PokerHandEvaluator/blob/develop/Documentation/Algorithm.md).

### Evaluating Flushes
First step is determining if the hand is a flush (or straight flush).

If there is at least 5 cards in the same color the hand is a flush or straight flush. Notice that if there is 5 cards in the same color, there is no possibility for any better hand (like full house or four of a kind).
Cards in flush color are now converted to `flush cards hash` which is 13-bits number in which set bits corresponds to type of cards in the flush color.  

Based on the 13-bits value the ranking of the hand is given (using [FlushHashtable](HoldemPoker.Evaluator/Hashtables/FlushHashtable.cs))

### Evaluating non-flush hands 
If the hand is not a flush, only card types matters. This means we count the number of each card types (number of aces, kings, etc.) forming 13-digits quinary (base 5) number. Each digit represents number of card of given type (from 0 to 4).

Next step is converting this quinary number to a `quinary hash` that will allow to get hand ranking from proper hashtable ([Hashtable5](HoldemPoker.Evaluator/Hashtables/Hashtable5.cs), [Hashtable6](HoldemPoker.Evaluator/Hashtables/Hashtable6.cs) or [Hashtable7](HoldemPoker.Evaluator/Hashtables/Hashtable7.cs)).
Details about creation of `quinary hash` can be found in [original algorithm documentation](https://github.com/HenryRLee/PokerHandEvaluator/blob/develop/Documentation/Algorithm.md#chapter-3-hash-for-a-restricted-quinary) by [HenryRLee](https://github.com/HenryRLee).

## Testing
See [unit tests](HoldemPoker.Evaluator.Tests)

## License
The project is licensed under the Apache 2.0 License - see the [LICENSE](LICENSE) file for details.

## Author
Written and tested by Mateusz Bąkała (bakala12@o2.pl)