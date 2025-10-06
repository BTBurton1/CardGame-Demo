using Microsoft.VisualStudio.TestTools.UnitTesting;
using Cards2;

namespace CardDeckPlayerTest
{
    [TestClass]
    public class PlayerTests
    {
        [TestMethod]
        public void Player_ShouldStartWithEmptyHand()
        {
            var player = new Player("Bilal");
            Assert.AreEqual(0, player.Hand.Count, "New player should start with an empty hand.");
        }

        [TestMethod]
        public void Player_AddCard_ShouldIncreaseHandCount()
        {
            var player = new Player("Bilal");
            var card = new Card(Rank.Queen, Suit.Diamonds);

            player.AddCard(card);
            Assert.AreEqual(1, player.Hand.Count, "Adding a card should increase hand count.");
            Assert.AreEqual(card, player.Hand[0]);
        }

        [TestMethod]
        public void Player_ClearHand_ShouldRemoveAllCards()
        {
            var player = new Player("Bilal");
            player.AddCard(new Card(Rank.Ten, Suit.Hearts));
            player.AddCard(new Card(Rank.Jack, Suit.Spades));

            player.ClearHand();
            Assert.AreEqual(0, player.Hand.Count, "Clearing the hand should remove all cards.");
        }
    }
}
