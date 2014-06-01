using System;
using System.Collections.Generic;

namespace Poker
{
    public class PokerHandsChecker : IPokerHandsChecker
    {
        public bool IsValidHand(IHand hand)
        {
            ICard card1 = hand.Cards[0];
            ICard card2 = hand.Cards[1];
            ICard card3 = hand.Cards[2];
            ICard card4 = hand.Cards[3];
            ICard card5 = hand.Cards[4];

            if (card1.Equals(card2) || card1.Equals(card3) || card1.Equals(card4) || card1.Equals(card5))
            {
                return false;
            }
            else if (card2.Equals(card3) || card2.Equals(card4) || card2.Equals(card5))
            {
                return false;
            }
            else if (card3.Equals(card4) || card3.Equals(card5))
            {
                return false;
            }

            return true;
        }

        public bool IsStraightFlush(IHand hand)
        {
            throw new NotImplementedException();
            //var faces = new List<int>(5);
            //if (!this.IsFlush(hand))
            //{
            //    return false;
            //}
            //else
            //{
            //    foreach (var card in hand.Cards)
            //    {
            //        faces.Add((int)card.Suit);
            //    }
            //}

            //faces.Sort();
            //for (int i = 0; i < faces.Count - 1; i++)
            //{
            //    if (faces[i] + 1 != faces[i+1])
            //    {
            //        return false;
            //    }
            //}

            //return true;
        }

        public bool IsFourOfAKind(IHand hand)
        {
            int[] arr = new int[15];
            foreach (var card in hand.Cards)
            {
                arr[(int)card.Face]++;
            }

            foreach (var nums in arr)
            {
                if (nums == 4)
                {
                    return true;
                }
            }

            return false;
        }

        public bool IsFullHouse(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsFlush(IHand hand)
        {
            int suit = (int)hand.Cards[0].Suit;
            for (int i = 1; i < hand.Cards.Count; i++)
            {
                var currentCard = hand.Cards[i];
                if ((int)currentCard.Suit != suit)
                {
                    return false;
                }
            }

            return true;
        }

        public bool IsStraight(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsThreeOfAKind(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsTwoPair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsOnePair(IHand hand)
        {
            throw new NotImplementedException();
        }

        public bool IsHighCard(IHand hand)
        {
            int[] arr = new int[15];
            foreach (var card in hand.Cards)
            {
                arr[(int)card.Face]++;
            }

            foreach (var nums in arr)
            {
                if (nums >= 2)
                {
                    return false;
                }
            }

            return true;
        }

        public int CompareHands(IHand firstHand, IHand secondHand)
        {
            throw new NotImplementedException();
        }
    }
}
