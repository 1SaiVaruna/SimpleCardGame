using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCardGame
{
    internal class Player
    {
        private string name;
        private List<Card> hand;

        public Player(string name)
        {
            this.name = name;
            hand = new List<Card>();
        }

        public void AddCard(Card card)
        {
            hand.Add(card);
        }

        public void ShowHand()
        {
            Console.WriteLine($"{name}'s hand: ");
            foreach (Card card in hand)
            {
                Console.WriteLine(card);
            }
        }

        public void Score()
        {
            int score = 0;
            foreach (Card card in hand)
            {
                score += card.Value();
            }
        }
    }
}
