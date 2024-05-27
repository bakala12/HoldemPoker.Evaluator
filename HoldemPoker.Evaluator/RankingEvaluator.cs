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
using HoldemPoker.Evaluator.Helpers;

namespace HoldemPoker.Evaluator;

internal static class RankingEvaluator
{
    internal static int Evaluate5CardRating(Card card1, Card card2, Card card3, Card card4, Card card5)
    {
        var flushHash = FlushHashHelper.GetFlushHash(card1, card2, card3, card4, card5);
        var flushColor = IsFlushHashtable.IsFlush[flushHash] - 1;
        if (flushColor >= 0)
        {
            var flushCardsHash = FlushHashHelper.GetFlushCardsHash(flushColor, card1, card2, card3, card4, card5);
            return FlushHashtable.FlushesRankings[flushCardsHash];
        }

        byte[] quinary = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        quinary[(card1 >> 2)]++;
        quinary[(card2 >> 2)]++;
        quinary[(card3 >> 2)]++;
        quinary[(card4 >> 2)]++;
        quinary[(card5 >> 2)]++;

        return Hashtable5.NoFlush5CardsRankings[QuinaryHashHelper.HashQuinary(quinary, 5)];
    }

    internal static int Evaluate6CardRating(Card card1, Card card2, Card card3, Card card4, Card card5, Card card6)
    {
        var flushHash = FlushHashHelper.GetFlushHash(card1, card2, card3, card4, card5, card6);
        var flushColor = IsFlushHashtable.IsFlush[flushHash] - 1;
        if (flushColor >= 0)
        {
            var flushCardsHash = FlushHashHelper.GetFlushCardsHash(flushColor, card1, card2, card3, card4, card5, card6);
            return FlushHashtable.FlushesRankings[flushCardsHash];
        }

        byte[] quinary = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        quinary[(card1 >> 2)]++;
        quinary[(card2 >> 2)]++;
        quinary[(card3 >> 2)]++;
        quinary[(card4 >> 2)]++;
        quinary[(card5 >> 2)]++;
        quinary[(card6 >> 2)]++;

        return Hashtable6.NoFlush6CardsRankings[QuinaryHashHelper.HashQuinary(quinary, 6)];
    }

    internal static int Evaluate7CardRating(Card card1, Card card2, Card card3, Card card4, Card card5, Card card6, Card card7)
    {
        var flushHash = FlushHashHelper.GetFlushHash(card1, card2, card3, card4, card5, card6, card7);
        var flushColor = IsFlushHashtable.IsFlush[flushHash] - 1;
        if (flushColor >= 0)
        {
            var flushCardsHash = FlushHashHelper.GetFlushCardsHash(flushColor, card1, card2, card3, card4, card5, card6, card7);
            return FlushHashtable.FlushesRankings[flushCardsHash];
        }

        byte[] quinary = [0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0];

        quinary[(card1 >> 2)]++;
        quinary[(card2 >> 2)]++;
        quinary[(card3 >> 2)]++;
        quinary[(card4 >> 2)]++;
        quinary[(card5 >> 2)]++;
        quinary[(card6 >> 2)]++;
        quinary[(card7 >> 2)]++;

        return Hashtable7.NoFlush7CardsRankings[QuinaryHashHelper.HashQuinary(quinary, 7)];
    }
}