namespace HoldemPoker.Evaluator.Tests;

public class HandCategoriesTests
{
    [Theory]
    [InlineData("AhQhThJhKh", PokerHandCategory.RoyalFlush, "Royal Flush")]
    [InlineData("KdQdJdTd9d", PokerHandCategory.StraightFlush, "King-High Straight Flush")]
    [InlineData("5d5h5c5s6d", PokerHandCategory.FourOfAKind, "Four Fives")]
    [InlineData("4d4s6c6s6h", PokerHandCategory.FullHouse, "Sixes Full over Fours")]
    [InlineData("AhTh7h2h3h", PokerHandCategory.Flush, "Ace-High Flush")]
    [InlineData("Ad2s3h4c5h", PokerHandCategory.Straight, "Five-High Straight")]
    [InlineData("3d4s6c6s6h", PokerHandCategory.ThreeOfAKind, "Three Sixes")]
    [InlineData("4d4c5h6d6h", PokerHandCategory.TwoPairs, "Sixes and Fours")]
    [InlineData("AdAc4h5h6h", PokerHandCategory.OnePair, "Pair of Aces")]
    [InlineData("9dKdTh5h4c", PokerHandCategory.HighCard, "King-High")]
    public void FiveCardsPokerHandCategoryTest(string cards, PokerHandCategory expectedCategory, string expectedDescription)
    {
        var cardArray = Parse(cards).ToArray();
        var actualCategory = HoldemHandEvaluator.GetHandCategory(cardArray);
        Assert.Equal(expectedCategory, actualCategory);
        var actualDescription = HoldemHandEvaluator.GetHandDescription(cardArray);
        Assert.Equal(expectedDescription, actualDescription);
    }

    [Theory]
    [InlineData("9hAhQhThJhKh", PokerHandCategory.RoyalFlush, "Royal Flush")]
    [InlineData("8dAdQdJdTd9d", PokerHandCategory.StraightFlush, "Queen-High Straight Flush")]
    [InlineData("KdKhKc5c5sKs", PokerHandCategory.FourOfAKind, "Four Kings")]
    [InlineData("KdKhKc5c5s5d", PokerHandCategory.FullHouse, "Kings Full over Fives")]
    [InlineData("AhTh7hAd2h3h", PokerHandCategory.Flush, "Ace-High Flush")]
    [InlineData("2s3h4c5h3d6h", PokerHandCategory.Straight, "Six-High Straight")]
    [InlineData("3d4s6c6s6hAd", PokerHandCategory.ThreeOfAKind, "Three Sixes")]
    [InlineData("4d4cAd5h6d6h", PokerHandCategory.TwoPairs, "Sixes and Fours")]
    [InlineData("AdAc4h5h6hKs", PokerHandCategory.OnePair, "Pair of Aces")]
    [InlineData("9dKdTh5h4c2d", PokerHandCategory.HighCard, "King-High")]
    public void SixCardsPokerHandCategoryTest(string cards, PokerHandCategory expectedCategory, string expectedDescription)
    {
        var cardArray = Parse(cards).ToArray();
        var actualCategory = HoldemHandEvaluator.GetHandCategory(cardArray);
        Assert.Equal(expectedCategory, actualCategory);
        var actualDescription = HoldemHandEvaluator.GetHandDescription(cardArray);
        Assert.Equal(expectedDescription, actualDescription);
    }

    [Theory]
    [InlineData("9hAhQhThJhKhAd", PokerHandCategory.RoyalFlush, "Royal Flush")]
    [InlineData("8dAdQdJdTd9d2d", PokerHandCategory.StraightFlush, "Queen-High Straight Flush")]
    [InlineData("KdKhKc5c5sKs5h", PokerHandCategory.FourOfAKind, "Four Kings")]
    [InlineData("KdKhKc5c5s5dAd", PokerHandCategory.FullHouse, "Kings Full over Fives")]
    [InlineData("AhTh7hAd2h3hAs", PokerHandCategory.Flush, "Ace-High Flush")]
    [InlineData("2s3h4c5h3d6hKh", PokerHandCategory.Straight, "Six-High Straight")]
    [InlineData("3d4s6c6s6hAdKs", PokerHandCategory.ThreeOfAKind, "Three Sixes")]
    [InlineData("4d4cAd5h6d6hKs", PokerHandCategory.TwoPairs, "Sixes and Fours")]
    [InlineData("AdAc4h5h6hKsQh", PokerHandCategory.OnePair, "Pair of Aces")]
    [InlineData("9dKdTh5h4c2d3c", PokerHandCategory.HighCard, "King-High")]
    public void SevenCardsPokerHandCategoryTest(string cards, PokerHandCategory expectedCategory, string expectedDescription)
    {
        var cardArray = Parse(cards).ToArray();
        var actualCategory = HoldemHandEvaluator.GetHandCategory(cardArray);
        Assert.Equal(expectedCategory, actualCategory);
        var actualDescription = HoldemHandEvaluator.GetHandDescription(cardArray);
        Assert.Equal(expectedDescription, actualDescription);
    }

    [Theory]
    [InlineData("")]
    [InlineData("3d")]
    [InlineData("3d4h")]
    [InlineData("3d4h5s")]
    [InlineData("3d4h5sAc")]
    [InlineData("3d4h5sAcJdQhKsQd")]
    [InlineData("3d4h5sAcJdQhKsQd5cTcTdTh")]
    public void InvalidCardCountHandShouldThrowExceptionTest(string cards)
    {
        var ex = Assert.Throws<ArgumentException>(() => HoldemHandEvaluator.GetHandCategory(Parse(cards).ToArray()));
        Assert.NotNull(ex);
        Assert.Equal("Invalid number of cards", ex.Message);
    }

    [Fact]
    public void NullCardCollectionShouldThrowArgumentNullExceptionTest()
    {
        Assert.Throws<ArgumentNullException>(() => HoldemHandEvaluator.GetHandCategory(null!));
    }

    private static IEnumerable<Card> Parse(string cardStr)
        => cardStr.Chunk(2).Select(c => Card.Parse($"{c[0]}{c[1]}"));
}