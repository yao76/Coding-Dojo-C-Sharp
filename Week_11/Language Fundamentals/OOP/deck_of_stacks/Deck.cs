using System;
using System.Collections.Generic;

namespace deck_of_stacks
{
    public class Deck
    {
        private string[] suits = new string[4] { "Hearts", "Diamonds", "Spades", "Clubs" };
        private string[] stringVal = new string[13] { "Ace", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Jack", "Queen", "King" };
        private int[] val = new int[13] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };
        private List<Card> cards = new List<Card>();
        public Deck()
        {
            Reset();
        }

        public Card Deal()
        {
            if (cards.Count > 0)
            {
                Card cardToDeal = cards[0];
                cards.RemoveAt(0);
                return cardToDeal;
            }
            else
            {
                System.Console.WriteLine("Deck is empty");
                return null;
            }
        }

        public void Reset()
        {
            this.cards = new List<Card>();
            for (int i = 0; i < suits.Length; i++)
            {
                for (int j = 0; j < stringVal.Length; j++)
                {
                    this.cards.Add(new Card(suits[i], stringVal[j], val[j]));
                }
            }
        }
        public void shuffle()
        {
            Random r = new Random();
            for (int n = this.cards.Count - 1; n > 0; --n)
            {
                int k = r.Next(n + 1);
                Card temp = this.cards[n];
                this.cards[n] = this.cards[k];
                this.cards[k] = temp;
            }

        }
    }
}
