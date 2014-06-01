using System;
using Poker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
namespace Tests
{
    [TestClass]
    public class PokerHandsTests
    {
        [TestMethod]
        public void TestToStringAceSpades()
        {
            Card card = new Card(CardFace.Ace, CardSuit.Spades);
            string expected = "A♠";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringTenDiamond()
        {
            Card card = new Card(CardFace.Ten, CardSuit.Diamonds);
            string expected = "10♦";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringSevenClubs()
        {
            Card card = new Card(CardFace.Seven, CardSuit.Clubs);
            string expected = "7♣";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestToStringKingHeart()
        {
            Card card = new Card(CardFace.King, CardSuit.Hearts);
            string expected = "K♥";
            string actual = card.ToString();

            Assert.AreEqual(expected, actual);
        }
    }
}
