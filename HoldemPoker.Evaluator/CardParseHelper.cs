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