using System;
using System.Collections.Generic;

namespace Poker
{
    class PokerExample
    {
        static void Main()
        {
            //ICard card = new Card(CardFace.Ace, CardSuit.Clubs);
            //Console.WriteLine(card);

            //IHand hand = new Hand(new List<ICard>() { 
            //    new Card(CardFace.Ace, CardSuit.Clubs),
            //    new Card(CardFace.Ace, CardSuit.Diamonds),
            //    new Card(CardFace.King, CardSuit.Hearts),
            //    new Card(CardFace.King, CardSuit.Spades),
            //    new Card(CardFace.Seven, CardSuit.Diamonds),
            //});
            //Console.WriteLine(hand);

            //IPokerHandsChecker checker = new PokerHandsChecker();
            //Console.WriteLine(checker.IsValidHand(hand));
            //Console.WriteLine(checker.IsOnePair(hand));
            //Console.WriteLine(checker.IsTwoPair(hand));

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

            Console.WriteLine(hand);
        }
    }
}
