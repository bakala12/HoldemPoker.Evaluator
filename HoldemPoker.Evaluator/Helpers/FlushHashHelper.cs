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

internal static class FlushHashHelper
{
    private static readonly short[] ColorBits = new short[52]
    {
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200,
        0x1, 0x8, 0x40, 0x200
    };

    private static readonly ulong[] CardBits = new ulong[52]
    {
        1, 8192, 67108864, 549755813888,
        2, 16384, 134217728, 1099511627776,
        4, 32768, 268435456, 2199023255552,
        8, 65536, 536870912, 4398046511104,
        16, 131072, 1073741824, 8796093022208,
        32, 262144, 2147483648, 17592186044416,
        64, 524288, 4294967296, 35184372088832,
        128, 1048576, 8589934592, 70368744177664,
        256, 2097152, 17179869184, 140737488355328,
        512, 4194304, 34359738368, 281474976710656,
        1024, 8388608, 68719476736, 562949953421312,
        2048, 16777216, 137438953472, 1125899906842624,
        4096, 33554432, 274877906944, 2251799813685248
    };

    internal static int GetFlushHash(Card card1, Card card2, Card card3, Card card4, Card card5)
    {
        int colorHash = 0;
        colorHash += ColorBits[card1];
        colorHash += ColorBits[card2];
        colorHash += ColorBits[card3];
        colorHash += ColorBits[card4];
        colorHash += ColorBits[card5];
        return colorHash;
    }

    internal static int GetFlushHash(Card card1, Card card2, Card card3, Card card4, Card card5, Card card6)
    {
        int colorHash = 0;
        colorHash += ColorBits[card1];
        colorHash += ColorBits[card2];
        colorHash += ColorBits[card3];
        colorHash += ColorBits[card4];
        colorHash += ColorBits[card5];
        colorHash += ColorBits[card6];
        return colorHash;
    }

    internal static int GetFlushHash(Card card1, Card card2, Card card3, Card card4, Card card5, Card card6, Card card7)
    {
        int colorHash = 0;
        colorHash += ColorBits[card1];
        colorHash += ColorBits[card2];
        colorHash += ColorBits[card3];
        colorHash += ColorBits[card4];
        colorHash += ColorBits[card5];
        colorHash += ColorBits[card6];
        colorHash += ColorBits[card7];
        return colorHash;
    }

    internal static ulong GetFlushCardsHash(int flushColor, Card card1, Card card2, Card card3, Card card4, Card card5)
    {
        ulong cardsHash = 0UL;
        cardsHash |= CardBits[card1];
        cardsHash |= CardBits[card2];
        cardsHash |= CardBits[card3];
        cardsHash |= CardBits[card4];
        cardsHash |= CardBits[card5];
        return (cardsHash >> (13 * flushColor)) & 0x1FFF;
    }

    internal static ulong GetFlushCardsHash(int flushColor, Card card1, Card card2, Card card3, Card card4, Card card5, Card card6)
    {
        ulong cardsHash = 0UL;
        cardsHash |= CardBits[card1];
        cardsHash |= CardBits[card2];
        cardsHash |= CardBits[card3];
        cardsHash |= CardBits[card4];
        cardsHash |= CardBits[card5];
        cardsHash |= CardBits[card6];
        return (cardsHash >> (13 * flushColor)) & 0x1FFF;
    }

    internal static ulong GetFlushCardsHash(int flushColor, Card card1, Card card2, Card card3, Card card4, Card card5, Card card6, Card card7)
    {
        ulong cardsHash = 0UL;
        cardsHash |= CardBits[card1];
        cardsHash |= CardBits[card2];
        cardsHash |= CardBits[card3];
        cardsHash |= CardBits[card4];
        cardsHash |= CardBits[card5];
        cardsHash |= CardBits[card6];
        cardsHash |= CardBits[card7];
        return (cardsHash >> (13 * flushColor)) & 0x1FFF;
    }
}