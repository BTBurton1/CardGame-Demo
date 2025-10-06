using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cards2;

namespace CardDeckPlayerTest
{
    [TestClass]
    public class CardTests
    {
        [TestMethod]
        public void Card_ShouldStoreRankAndSuit()
        {
            var card = new Card(Rank.Ace, Suit.Spades);
            Assert.AreEqual(Rank.Ace, card.Rank);
            Assert.AreEqual(Suit.Spades, card.Suit);
        }

        [TestMethod]
        public void Card_ToString_ReturnsReadableFormat()
        {
            var card = new Card(Rank.King, Suit.Hearts);
            Assert.AreEqual("King of Hearts", card.ToString());
        }
    }
}
