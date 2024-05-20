namespace HoldemPoker.Evaluator;

/// <summary>
/// Structure representing a card as a value (from 0 to 51).
/// Card color is 2 less significant bits, card type is number 0-12 on bits 2-5.
/// </summary>
/// <param name="Value">Value of the card.</param>
public readonly record struct Card(byte Value)
{
    /// <summary>
    /// Creates a new value of Card structure with the specified type and color.
    /// </summary>
    /// <param name="type">Card type.</param>
    /// <param name="color">Card color.</param>
    public Card(CardType type, CardColor color) : this((byte)(((int)type << 2) | ((int)color & 0x3))) { }

    /// <summary>
    /// Gets the type of the Card.
    /// </summary>
    public CardType Type => (CardType)(Value >> 2);

    /// <summary>
    /// Gets the Color of the Card.
    /// </summary>
    public CardColor Color => (CardColor)(Value & 0x3);

    /// <summary>
    /// Implicit conversion operator from Card to byte.
    /// </summary>
    /// <param name="c">Card to be converted to byte.</param>
    /// <returns>Byte representation of the card.</returns>
    public static implicit operator byte(Card c) => c.Value;

    /// <summary>
    /// Implicit conversion operator from byte to Card.
    /// </summary>
    /// <param name="b">Byte value.</param>
    /// <returns>Card structure representation of the byte value.</returns>
    public static implicit operator Card(byte b) => new Card(b);

    /// <summary>
    /// Gets the string representation of the Card.
    /// </summary>
    /// <returns>String representation of the Card</returns>
    public override string ToString() => $"{Type.ToChar()}{Color.ToChar()}";

    /// <summary>
    /// Parses string to be represented as a Card.
    /// </summary>
    /// <param name="str">String representation of a Card.</param>
    /// <returns>Card structure represented by the string value.</returns>
    /// <exception cref="FormatException">If the string is invalid Card representation.
    /// Valid string is 2 characters long - first represents a type (A,K,Q,J,T,9,8,7,6,5,4,3,2) and a second represents color (h,d,c,s or unicode card colors (\u2665, \u2666, \u2663, \u2660).</exception>
    public static Card Parse(string str)
    {
        if (string.IsNullOrEmpty(str) || str.Length != 2)
            throw new FormatException("Invalid length of card string");
        return new Card(CardParseHelper.ToCardType(str[0]), CardParseHelper.ToCardColor(str[1]));
    }

    /// <summary>
    /// Tries to perform parsing of the given string instance to Card structure.
    /// </summary>
    /// <param name="str">String representation of a Card.</param>
    /// <param name="card">Output parameter - Card structure represented by the string value.</param>
    /// <returns>True if string represents a Card, otherwise false.</returns>
    public static bool TryParse(string str, out Card card)
    {
        card = default;
        if(string.IsNullOrEmpty(str) || str.Length != 2)
            return false;
        var type = CardParseHelper.TryConvertToCardType(str[0]);
        var color= CardParseHelper.TryConvertToCardColor(str[1]);
        if (type.HasValue && color.HasValue)
        {
            card = new Card(type.Value, color.Value);
            return true;
        }
        return false;
    }
}