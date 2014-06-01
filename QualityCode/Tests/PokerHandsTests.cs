using System;
using Poker;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
namespace Tests
{
    [TestClass]
    public class PokerHandsCheckerTests
    {
        [TestMethod]
        public void HighCardTrueTest()
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

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void HighCardFalseTest()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.King, CardSuit.Spades);
            var card3 = new Card(CardFace.Seven, CardSuit.Diamonds);
            var card4 = new Card(CardFace.Ten, CardSuit.Clubs);
            var card5 = new Card(CardFace.Two, CardSuit.Spades);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);

            Hand hand = new Hand(cards);

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsHighCard(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidHandFalseTest()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.King, CardSuit.Hearts);
            var card3 = new Card(CardFace.Seven, CardSuit.Diamonds);
            var card4 = new Card(CardFace.Ten, CardSuit.Clubs);
            var card5 = new Card(CardFace.Two, CardSuit.Spades);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);            

            Hand hand = new Hand(cards);

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsValidHandTrueTest()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.King, CardSuit.Diamonds);
            var card3 = new Card(CardFace.Seven, CardSuit.Diamonds);
            var card4 = new Card(CardFace.Ten, CardSuit.Clubs);
            var card5 = new Card(CardFace.Two, CardSuit.Spades);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);

            Hand hand = new Hand(cards);

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsValidHand(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsFlushTrueTest()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.Queen, CardSuit.Hearts);
            var card3 = new Card(CardFace.Seven, CardSuit.Hearts);
            var card4 = new Card(CardFace.Ten, CardSuit.Hearts);
            var card5 = new Card(CardFace.Two, CardSuit.Hearts);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);

            Hand hand = new Hand(cards);

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsFlushFalseTest()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.Queen, CardSuit.Diamonds);
            var card3 = new Card(CardFace.Seven, CardSuit.Hearts);
            var card4 = new Card(CardFace.Ten, CardSuit.Hearts);
            var card5 = new Card(CardFace.Two, CardSuit.Hearts);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);

            Hand hand = new Hand(cards);

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFlush(hand);
            Assert.AreEqual(expected, actual);
        }        

        [TestMethod]
        public void IsFourOfAKindTrueTest()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.King, CardSuit.Diamonds);
            var card3 = new Card(CardFace.King, CardSuit.Clubs);
            var card4 = new Card(CardFace.King, CardSuit.Spades);
            var card5 = new Card(CardFace.Two, CardSuit.Spades);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);

            Hand hand = new Hand(cards);

            bool expected = true;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void IsFourOfAKindFalseTest()
        {
            var card1 = new Card(CardFace.King, CardSuit.Hearts);
            var card2 = new Card(CardFace.King, CardSuit.Diamonds);
            var card3 = new Card(CardFace.King, CardSuit.Clubs);
            var card4 = new Card(CardFace.Queen, CardSuit.Spades);
            var card5 = new Card(CardFace.Two, CardSuit.Spades);

            var cards = new List<ICard>();
            cards.Add(card1);
            cards.Add(card2);
            cards.Add(card3);
            cards.Add(card4);
            cards.Add(card5);

            Hand hand = new Hand(cards);

            bool expected = false;
            PokerHandsChecker checker = new PokerHandsChecker();
            bool actual = checker.IsFourOfAKind(hand);
            Assert.AreEqual(expected, actual);
        }       
    }
}
