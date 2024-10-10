using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCardGame
{
    internal class Card
    {
        private Suit suit;
        private Rank rank;

        public Card(Suit suit, Rank rank)
        {
            this.suit = suit;
            this.rank = rank;
        }

        public Suit Suit
        {
            get { return suit; }
        }

        public Rank Rank
        {
            get { return rank; }
        }

        public override string ToString()
        {
            return $"{rank} of {suit}";
        }

        public int Value()
        {
            int value = (int)rank;

            if (value > 10)
            {
                value = 10;
            }

            return value;
        }



    }
}
