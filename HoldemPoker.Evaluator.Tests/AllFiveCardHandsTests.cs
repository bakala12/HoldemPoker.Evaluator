using HoldemPoker.Evaluator.Tests.Utils;

namespace HoldemPoker.Evaluator.Tests;

public class AllFiveCardHandsTests
{
    [Fact]
    public void TestsAllRoyalFlushes()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllRoyalFlushes())
        {
            Assert.Equal(PokerHandCategory.RoyalFlush, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(4, c);
    }

    [Fact]
    public void TestsAllStraightFlushes()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllStraightFlushes())
        {
            Assert.Equal(PokerHandCategory.StraightFlush, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(36, c);
    }

    [Fact]
    public void TestsAllFourOfAKinds()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllFourOfAKinds())
        {
            Assert.Equal(PokerHandCategory.FourOfAKind, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(624, c);
    }

    [Fact]
    public void TestAllFullHouses()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllFullHouses())
        {
            Assert.Equal(PokerHandCategory.FullHouse, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(3744, c);
    }

    [Fact]
    public void TestAllFlushes()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllFlushes())
        {
            Assert.Equal(PokerHandCategory.Flush, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(5108, c);
    }

    [Fact]
    public void TestAllStraights()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllStraights())
        {
            Assert.Equal(PokerHandCategory.Straight, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(10200, c);
    }

    [Fact]
    public void TestAllThreeOfAKinds()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllThreeOfAKinds())
        {
            Assert.Equal(PokerHandCategory.ThreeOfAKind, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(54912, c);
    }

    [Fact]
    public void TestAllTwoPairs()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllTwoPairs())
        {
            Assert.Equal(PokerHandCategory.TwoPairs, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(123552, c);
    }

    [Fact]
    public void TestAllOnePairs()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllOnePairs())
        {
            Assert.Equal(PokerHandCategory.OnePair, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(1098240, c);
    }

    [Fact]
    public void TestAllHighCards()
    {
        int c = 0;
        foreach (var hand in HandsProvider.GetAllHighCards())
        {
            Assert.Equal(PokerHandCategory.HighCard, HoldemHandEvaluator.GetHandCategory(GetCards(hand).ToArray()));
            c++;
        }
        Assert.Equal(1302540, c);
    }

    private static IEnumerable<Card> GetCards(ulong cards)
    {
        while (cards != 0)
        {
            yield return (Card)ulong.TrailingZeroCount(cards);
            cards &= (cards - 1);
        }
    }
}