namespace HoldemPoker.Evaluator.Tests;

public class CardParsingTests
{
    [Theory]
    [InlineData("As", CardType.Ace, CardColor.Spade)]
    [InlineData("Kh", CardType.King, CardColor.Heart)]
    [InlineData("Qd", CardType.Queen, CardColor.Diamond)]
    [InlineData("Jc", CardType.Jack, CardColor.Club)]
    [InlineData("Td", CardType.Ten, CardColor.Diamond)]
    [InlineData("9h", CardType.Nine, CardColor.Heart)]
    [InlineData("8c", CardType.Eight, CardColor.Club)]
    [InlineData("7s", CardType.Seven, CardColor.Spade)]
    [InlineData("6h", CardType.Six, CardColor.Heart)]
    [InlineData("5d", CardType.Five, CardColor.Diamond)]
    [InlineData("4s", CardType.Four, CardColor.Spade)]
    [InlineData("3d", CardType.Three, CardColor.Diamond)]
    [InlineData("2c", CardType.Deuce, CardColor.Club)]
    public void ParsingCardShouldBeOk(string cardStr, CardType expectedType, CardColor expectedColor)
    {
        var card = Card.Parse(cardStr);
        Assert.Equal(expectedType, card.Type);
        Assert.Equal(expectedColor, card.Color);

        Assert.True(Card.TryParse(cardStr, out var card1));
        Assert.Equal(expectedType, card1.Type);
        Assert.Equal(expectedColor, card1.Color);
    }

    [Theory]
    [InlineData("A\u2660", CardType.Ace, CardColor.Spade)]
    [InlineData("K\u2665", CardType.King, CardColor.Heart)]
    [InlineData("Q\u2666", CardType.Queen, CardColor.Diamond)]
    [InlineData("J\u2663", CardType.Jack, CardColor.Club)]
    [InlineData("T\u2666", CardType.Ten, CardColor.Diamond)]
    [InlineData("9\u2665", CardType.Nine, CardColor.Heart)]
    [InlineData("8\u2663", CardType.Eight, CardColor.Club)]
    [InlineData("7\u2660", CardType.Seven, CardColor.Spade)]
    [InlineData("6\u2665", CardType.Six, CardColor.Heart)]
    [InlineData("5\u2666", CardType.Five, CardColor.Diamond)]
    [InlineData("4\u2660", CardType.Four, CardColor.Spade)]
    [InlineData("3\u2666", CardType.Three, CardColor.Diamond)]
    [InlineData("2\u2663", CardType.Deuce, CardColor.Club)]
    public void ToStringAndColorConversionTest(string cardStr, CardType expectedType, CardColor expectedColor)
    {
        ParsingCardShouldBeOk(cardStr, expectedType, expectedColor);
        var card = new Card(expectedType, expectedColor);
        Assert.Equal(card.ToString(), cardStr);
    }

    [Fact]
    public void InvalidCardTypeShouldThrowException()
    {
        var ex = Assert.Throws<FormatException>(() => Card.Parse("Bs"));
        Assert.NotNull(ex);
        Assert.Equal("Invalid card type", ex.Message);
        Assert.False(Card.TryParse("Bs", out _));
    }

    [Fact]
    public void InvalidCardColorShouldThrowException()
    {
        var ex = Assert.Throws<FormatException>(() => Card.Parse("89"));
        Assert.NotNull(ex);
        Assert.Equal("Invalid card color", ex.Message);
        Assert.False(Card.TryParse("89", out _));
    }

    [Theory]
    [InlineData(null)]
    [InlineData("")]
    [InlineData("2")]
    [InlineData("10h")]
    public void InvalidCardConversionShouldThrowException(string str)
    {
        Assert.Throws<FormatException>(() => Card.Parse(str));
        Assert.False(Card.TryParse(str, out _));
    }

    [Fact]
    public void InvalidCardResultInToStringException()
    {
        Assert.Throws<FormatException>(() => new Card(52).ToString());
    }
}