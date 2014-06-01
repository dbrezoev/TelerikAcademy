using System;
using System.Collections.Generic;
using System.Text;

namespace Poker
{
    public class Hand : IHand
    {
        //public IList<ICard> Cards { get; private set; }
        private IList<ICard> cards;

        public Hand(IList<ICard> cards)
        {
            this.Cards = cards;
        }

        public IList<ICard> Cards
        {
            get
            {
                return new List<ICard>(this.cards);
            }

            private set
            {
                this.cards = value;
            }
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();

            foreach (var card in this.Cards)
            {
                result.Append(card.ToString());
            }

            return result.ToString();
        }
    }
}
