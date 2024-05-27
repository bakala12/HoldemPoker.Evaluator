/*
 *  Copyright 2016-2019 Henry Lee
 *  Ported from C++ to C# 2024 Mateusz Bąkała
 *
 *  Licensed under the Apache License, Version 2.0 (the "License");
 *  you may not use this file except in compliance with the License.
 *  You may obtain a copy of the License at
 *
 *      http://www.apache.org/licenses/LICENSE-2.0
 *
 *  Unless required by applicable law or agreed to in writing, software
 *  distributed under the License is distributed on an "AS IS" BASIS,
 *  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 *  See the License for the specific language governing permissions and
 *  limitations under the License.
 */

using HoldemPoker.Cards;
using HoldemPoker.Evaluator.Hashtables;

namespace HoldemPoker.Evaluator;

/// <summary>
/// Static class that contains methods for evaluating Texas Hold'em Poker hand.
/// </summary>
public static class HoldemHandEvaluator
{
    /// <summary>
    /// Gets the integer number informing of how good the hand is. The lower the ranking the better the hand is. 
    /// </summary>
    /// <param name="cards">Collection of cards representing poker hand.</param>
    /// <returns></returns>
    /// <exception cref="ArgumentNullException">If cards collection is null.</exception>
    /// <exception cref="ArgumentException">If cards collection contains less than 5 or more than 7 cards.</exception>
    public static int GetHandRanking(params Card[] cards)
    {
        if (cards == null) throw new ArgumentNullException(nameof(cards));
        return cards.Length switch
        {
            5 => RankingEvaluator.Evaluate5CardRating(cards[0], cards[1], cards[2], cards[3], cards[4]),
            6 => RankingEvaluator.Evaluate6CardRating(cards[0], cards[1], cards[2], cards[3], cards[4], cards[5]),
            7 => RankingEvaluator.Evaluate7CardRating(cards[0], cards[1], cards[2], cards[3], cards[4], cards[5], cards[6]),
            _ => throw new ArgumentException("Invalid number of cards")
        };
    }

    /// <summary>
    /// Gets the description of the hand.
    /// </summary>
    /// <param name="ranking">Ranking of poker hand (got by calling GetHandRanking method).</param>
    /// <returns>String containing description of poker hand, for example "Royal Flush" Or "Pair of Kings".</returns>
    /// <exception cref="ArgumentNullException">If cards collection is null.</exception>
    /// <exception cref="ArgumentException">If cards collection contains less than 5 or more than 7 cards.</exception>
    public static string GetHandDescription(int ranking) => PokerHandRankings.PokerHands[ranking];

    /// <summary>
    /// Gets the description of the hand.
    /// </summary>
    /// <param name="cards">Collection of cards representing poker hand.</param>
    /// <returns>String containing description of poker hand, for example "Royal Flush" Or "Pair of Kings".</returns>
    /// <exception cref="ArgumentNullException">If cards collection is null.</exception>
    /// <exception cref="ArgumentException">If cards collection contains less than 5 or more than 7 cards.</exception>
    public static string GetHandDescription(params Card[] cards) => GetHandDescription(GetHandRanking(cards));

    /// <summary>
    /// Gets the category of the hand.
    /// </summary>
    /// <param name="ranking">Ranking of poker hand (got by calling GetHandRanking method).</param>
    /// <returns>Poker hand category (like Flush or HighCard).</returns>
    /// <exception cref="ArgumentNullException">If cards collection is null.</exception>
    /// <exception cref="ArgumentException">If cards collection contains less than 5 or more than 7 cards.</exception>
    public static PokerHandCategory GetHandCategory(int ranking) => GetCategory(ranking);

    /// <summary>
    /// Gets the category of the hand.
    /// </summary>
    /// <param name="cards">Collection of cards representing poker hand.</param>
    /// <returns>Poker hand category (like Flush or HighCard).</returns>
    /// <exception cref="ArgumentNullException">If cards collection is null.</exception>
    /// <exception cref="ArgumentException">If cards collection contains less than 5 or more than 7 cards.</exception>
    public static PokerHandCategory GetHandCategory(params Card[] cards) => GetHandCategory(GetHandRanking(cards));

    private static PokerHandCategory GetCategory(int rank)
    {
        if (rank > 6185) return PokerHandCategory.HighCard;        // 1277 high card
        if (rank > 3325) return PokerHandCategory.OnePair;         // 2860 one pair
        if (rank > 2467) return PokerHandCategory.TwoPairs;         //  858 two pairs
        if (rank > 1609) return PokerHandCategory.ThreeOfAKind;  //  858 three-kind
        if (rank > 1599) return PokerHandCategory.Straight;         //   10 straights
        if (rank > 322) return PokerHandCategory.Flush;            // 1277 flushes
        if (rank > 166) return PokerHandCategory.FullHouse;       //  156 full house
        if (rank > 10) return PokerHandCategory.FourOfAKind;   //  156 four-kind
        if (rank > 1) return PokerHandCategory.StraightFlush;  //   9 straight-flushes
        return PokerHandCategory.RoyalFlush;
    }
}