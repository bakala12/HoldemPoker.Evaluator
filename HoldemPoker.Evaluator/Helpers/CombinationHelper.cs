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

namespace HoldemPoker.Evaluator.Helpers;

/// <summary>
/// Helper class for generating combinations of cards.
/// </summary>
internal static class CombinationHelper
{
    /// <summary>
    /// Generates all combinations of a specified number of cards from a given array.
    /// </summary>
    /// <param name="cards">The array of cards to generate combinations from.</param>
    /// <param name="count">The number of cards in each combination.</param>
    /// <returns>An enumerable of card arrays, each representing a unique combination.</returns>
    internal static IEnumerable<Card[]> GetCombinations(Card[] cards, int count)
    {
        if (count == 2)
        {
            return GetTwoCardCombinations(cards);
        }
        else if (count == 3)
        {
            return GetThreeCardCombinations(cards);
        }
        else
        {
            // General case (not currently needed, but included for completeness)
            return GetCombinationsGeneral(cards, count);
        }
    }

    /// <summary>
    /// Generates all 2-card combinations from the given array.
    /// Optimized implementation for k=2.
    /// </summary>
    private static IEnumerable<Card[]> GetTwoCardCombinations(Card[] cards)
    {
        int n = cards.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                yield return new Card[] { cards[i], cards[j] };
            }
        }
    }

    /// <summary>
    /// Generates all 3-card combinations from the given array.
    /// Optimized implementation for k=3.
    /// </summary>
    private static IEnumerable<Card[]> GetThreeCardCombinations(Card[] cards)
    {
        int n = cards.Length;
        for (int i = 0; i < n - 2; i++)
        {
            for (int j = i + 1; j < n - 1; j++)
            {
                for (int k = j + 1; k < n; k++)
                {
                    yield return new Card[] { cards[i], cards[j], cards[k] };
                }
            }
        }
    }

    /// <summary>
    /// General recursive implementation for generating combinations.
    /// Used for any value of count (though only 2 and 3 are needed for Omaha).
    /// </summary>
    private static IEnumerable<Card[]> GetCombinationsGeneral(Card[] cards, int count)
    {
        if (count == 0)
        {
            yield return Array.Empty<Card>();
            yield break;
        }

        if (count > cards.Length)
        {
            yield break;
        }

        // Use iterative approach with indices
        int[] indices = new int[count];
        for (int i = 0; i < count; i++)
        {
            indices[i] = i;
        }

        while (true)
        {
            // Yield current combination
            Card[] combination = new Card[count];
            for (int i = 0; i < count; i++)
            {
                combination[i] = cards[indices[i]];
            }
            yield return combination;

            // Find the rightmost index that can be incremented
            int pos = count - 1;
            while (pos >= 0 && indices[pos] == cards.Length - count + pos)
            {
                pos--;
            }

            // If no such index exists, we're done
            if (pos < 0)
            {
                break;
            }

            // Increment this index and reset all indices to its right
            indices[pos]++;
            for (int i = pos + 1; i < count; i++)
            {
                indices[i] = indices[i - 1] + 1;
            }
        }
    }
}
