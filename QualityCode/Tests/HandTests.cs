using System;
using Poker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Tests
{
    [TestClass]
    public class HandTests
    {        
        [TestMethod]
        public void TestHand()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.Five, CardSuit.Spades);
            var card3 = new Card(CardFace.Seven, CardSuit.Diamonds);
            var card4 = new Card(CardFace.Ten, CardSuit.Clubs);
            var card5 = new Card(CardFace.Two, CardSuit.Spades);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);

            // ♣
            // ♦
            // ♥
            // ♠
            
            Hand hand = new Hand(cards);

            string expected = "K♥5♠7♦10♣2♠";
            string actual = hand.ToString();
            Assert.AreEqual(expected, actual);
        }
    }
}
