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

namespace HoldemPoker.Evaluator;

internal static class CardParseHelper
{
    internal static char ToChar(this CardType type) => 
        type switch
        {
            CardType.Ace => 'A',
            CardType.King => 'K',
            CardType.Queen => 'Q',
            CardType.Jack => 'J',
            CardType.Ten => 'T',
            CardType.Nine => '9',
            CardType.Eight => '8',
            CardType.Seven => '7',
            CardType.Six => '6',
            CardType.Five => '5',
            CardType.Four => '4',
            CardType.Three => '3',
            CardType.Deuce => '2',
            _ => throw new FormatException("Invalid card type")
        };

    internal static char ToChar(this CardColor color) =>
        color switch
        {
            CardColor.Heart => '\u2665',
            CardColor.Diamond => '\u2666',
            CardColor.Club => '\u2663',
            CardColor.Spade => '\u2660',
            _ => throw new FormatException("Invalid card color")
        };

    internal static CardType ToCardType(char type) =>
        type switch
        {
            'A' => CardType.Ace,
            'K' => CardType.King,
            'Q' => CardType.Queen,
            'J' => CardType.Jack,
            'T' => CardType.Ten,
            '9' => CardType.Nine,
            '8' => CardType.Eight,
            '7' => CardType.Seven,
            '6' => CardType.Six,
            '5' => CardType.Five,
            '4' => CardType.Four,
            '3' => CardType.Three,
            '2' => CardType.Deuce,
            _ => throw new FormatException("Invalid card type")
        };

    internal static CardColor ToCardColor(char color) =>
        color switch
        {
            'h' or '\u2665' => CardColor.Heart,
            'd' or '\u2666' => CardColor.Diamond,
            'c' or '\u2663' => CardColor.Club,
            's' or '\u2660' => CardColor.Spade,
            _ => throw new FormatException("Invalid card color")
        };

    internal static CardType? TryConvertToCardType(char type) =>
        type switch
        {
            'A' => CardType.Ace,
            'K' => CardType.King,
            'Q' => CardType.Queen,
            'J' => CardType.Jack,
            'T' => CardType.Ten,
            '9' => CardType.Nine,
            '8' => CardType.Eight,
            '7' => CardType.Seven,
            '6' => CardType.Six,
            '5' => CardType.Five,
            '4' => CardType.Four,
            '3' => CardType.Three,
            '2' => CardType.Deuce,
            _ => null
        };

    internal static CardColor? TryConvertToCardColor(char color) =>
        color switch
        {
            'h' or '\u2665' => CardColor.Heart,
            'd' or '\u2666' => CardColor.Diamond,
            'c' or '\u2663' => CardColor.Club,
            's' or '\u2660' => CardColor.Spade,
            _ => null
        };
}