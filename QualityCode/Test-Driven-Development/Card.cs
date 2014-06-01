using System;

namespace Poker
{
    public class Card : ICard
    {
        public CardFace Face { get; private set; }
        public CardSuit Suit { get; private set; }

        public Card(CardFace face, CardSuit suit)
        {
            this.Face = face;
            this.Suit = suit;
        }

        public override string ToString()
        {
            string faceStr;

            if ((int)this.Face <= 10)
            {
                faceStr = ((int)this.Face).ToString();
            }
            else
            {
                faceStr = "" + this.Face.ToString()[0];
            }

            char suit;

            switch (this.Suit)
            {
                case CardSuit.Clubs:
                    suit = '♣';
                    break;
                case CardSuit.Diamonds:
                    suit = '♦';
                    break;
                case CardSuit.Hearts:
                    suit = '♥';
                    break;
                case CardSuit.Spades:
                    suit = '♠';
                    break;
                default:
                    throw new InvalidOperationException("Invalid suit: " + this.Suit);
                    break;
            }

            string cardStr = faceStr + suit;
            return cardStr;
        }


        public override bool Equals(object obj)
        {
            if (!(obj is Card))
            {
                return false;
            }

            Card other = (Card)obj;

            if (!Object.Equals(this.Face, other.Face))
            {
                return false;
            }

            if (!Object.Equals(this.Suit, other.Suit))
            {
                return false;
            }

            return true;
        }
        
    }
}
