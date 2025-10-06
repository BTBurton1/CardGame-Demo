using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cards2;
using System.Linq;

namespace CardDeckPlayerTest
{
    [TestClass]
    public class DeckTests
    {
        [TestMethod]
        public void Deck_ShouldContain52Cards()
        {
            var deck = new Deck();
            Assert.AreEqual(52, deck.Cards.Count, "Deck should start with 52 cards.");
        }

        [TestMethod]
        public void Deck_Shuffle_ShouldChangeOrder()
        {
            var deck = new Deck();
            var before = deck.Cards.ToList();

            deck.Shuffle();
            var after = deck.Cards.ToList();

            bool orderChanged = before.Zip(after, (a, b) => a == b).Any(eq => !eq);
            Assert.IsTrue(orderChanged, "Shuffle should randomize the order of cards.");
        }

        [TestMethod]
        public void Deck_DrawCard_ShouldRemoveTopCard()
        {
            var deck = new Deck();
            int startCount = deck.Cards.Count;

            var card = deck.DrawCard();
            Assert.IsNotNull(card);
            Assert.AreEqual(startCount - 1, deck.Cards.Count, "Deck size should decrease by 1 after drawing.");
        }
    }
}
