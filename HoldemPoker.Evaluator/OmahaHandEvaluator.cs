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
using HoldemPoker.Evaluator.Helpers;

namespace HoldemPoker.Evaluator;

/// <summary>
/// Static class that contains methods for evaluating Omaha Poker hands.
/// In Omaha, players must use exactly 2 cards from their hole cards and exactly 3 cards from the board.
/// </summary>
public static class OmahaHandEvaluator
{
    /// <summary>
    /// Gets the integer number informing of how good the Omaha hand is. The lower the ranking the better the hand is.
    /// </summary>
    /// <param name="holeCards">Player's hole cards (must be 4, 5, or 6 cards).</param>
    /// <param name="boardCards">Community board cards (must be 3, 4, or 5 cards).</param>
    /// <returns>The best hand ranking using exactly 2 cards from hole cards and 3 from board.</returns>
    /// <exception cref="ArgumentNullException">If holeCards or boardCards is null.</exception>
    /// <exception cref="ArgumentException">If card counts are invalid or duplicate cards are found.</exception>
    /// <remarks>
    /// Omaha rules require exactly 2 cards from the player's hand and exactly 3 from the board.
    /// For example, having 1 club in hand and 4 clubs on the board does NOT make a flush.
    /// </remarks>
    public static int GetHandRanking(Card[] holeCards, Card[] boardCards)
    {
        ValidateInputs(holeCards, boardCards);

        int bestRanking = int.MaxValue;

        // Generate all 2-card combinations from hole cards
        var holeCardCombinations = CombinationHelper.GetCombinations(holeCards, 2);

        // Generate all 3-card combinations from board cards
        var boardCardCombinations = CombinationHelper.GetCombinations(boardCards, 3);

        // Evaluate all possible 5-card hands
        foreach (var holePair in holeCardCombinations)
        {
            foreach (var boardTriple in boardCardCombinations)
            {
                // Evaluate this 5-card combination
                int ranking = RankingEvaluator.Evaluate5CardRating(
                    holePair[0], holePair[1],
                    boardTriple[0], boardTriple[1], boardTriple[2]
                );

                // Track the best (lowest) ranking
                if (ranking < bestRanking)
                {
                    bestRanking = ranking;

                    // Early termination: Royal Flush is the best possible hand
                    if (bestRanking == 1)
                    {
                        return bestRanking;
                    }
                }
            }
        }

        return bestRanking;
    }

    /// <summary>
    /// Gets the description of the Omaha hand.
    /// </summary>
    /// <param name="holeCards">Player's hole cards (must be 4, 5, or 6 cards).</param>
    /// <param name="boardCards">Community board cards (must be 3, 4, or 5 cards).</param>
    /// <returns>String containing description of poker hand, for example "Royal Flush" or "Pair of Kings".</returns>
    /// <exception cref="ArgumentNullException">If holeCards or boardCards is null.</exception>
    /// <exception cref="ArgumentException">If card counts are invalid or duplicate cards are found.</exception>
    public static string GetHandDescription(Card[] holeCards, Card[] boardCards)
    {
        int ranking = GetHandRanking(holeCards, boardCards);
        return GetHandDescription(ranking);
    }

    /// <summary>
    /// Gets the description of the hand from its ranking.
    /// </summary>
    /// <param name="ranking">Ranking of poker hand (got by calling GetHandRanking method).</param>
    /// <returns>String containing description of poker hand, for example "Royal Flush" or "Pair of Kings".</returns>
    public static string GetHandDescription(int ranking)
    {
        return HoldemHandEvaluator.GetHandDescription(ranking);
    }

    /// <summary>
    /// Gets the category of the Omaha hand.
    /// </summary>
    /// <param name="holeCards">Player's hole cards (must be 4, 5, or 6 cards).</param>
    /// <param name="boardCards">Community board cards (must be 3, 4, or 5 cards).</param>
    /// <returns>Poker hand category (like Flush or HighCard).</returns>
    /// <exception cref="ArgumentNullException">If holeCards or boardCards is null.</exception>
    /// <exception cref="ArgumentException">If card counts are invalid or duplicate cards are found.</exception>
    public static PokerHandCategory GetHandCategory(Card[] holeCards, Card[] boardCards)
    {
        int ranking = GetHandRanking(holeCards, boardCards);
        return GetHandCategory(ranking);
    }

    /// <summary>
    /// Gets the category of the hand from its ranking.
    /// </summary>
    /// <param name="ranking">Ranking of poker hand (got by calling GetHandRanking method).</param>
    /// <returns>Poker hand category (like Flush or HighCard).</returns>
    public static PokerHandCategory GetHandCategory(int ranking)
    {
        return HoldemHandEvaluator.GetHandCategory(ranking);
    }

    /// <summary>
    /// Validates that the inputs are correct for Omaha evaluation.
    /// </summary>
    private static void ValidateInputs(Card[] holeCards, Card[] boardCards)
    {
        // Null checks
        if (holeCards == null)
            throw new ArgumentNullException(nameof(holeCards));
        if (boardCards == null)
            throw new ArgumentNullException(nameof(boardCards));

        // Card count validation
        if (holeCards.Length < 4 || holeCards.Length > 6)
            throw new ArgumentException($"Hole cards must contain 4-6 cards, but contains {holeCards.Length}");
        if (boardCards.Length < 3 || boardCards.Length > 5)
            throw new ArgumentException($"Board cards must contain 3-5 cards, but contains {boardCards.Length}");

        // Check for duplicates within hole cards
        HashSet<Card> holeCardSet = new HashSet<Card>();
        foreach (var card in holeCards)
        {
            if (!holeCardSet.Add(card))
                throw new ArgumentException("Duplicate cards found in hole cards");
        }

        // Check for duplicates within board cards and between hole cards and board
        foreach (var card in boardCards)
        {
            if (holeCardSet.Contains(card))
                throw new ArgumentException("Duplicate cards found between hole cards and board");
            if (!holeCardSet.Add(card))
                throw new ArgumentException("Duplicate cards found in board");
        }
    }
}
