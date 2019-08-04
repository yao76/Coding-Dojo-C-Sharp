using System;
using System.Collections.Generic;

namespace deck_of_stacks
{
    public class Player : Deck
    {
        private string name;
        private List<Card> hand;

        public Player(string pname){
            this.name = pname;
            this.hand = new List<Card>();
        }

        public List<Card> Draw(Deck deck){
            for(int i = 0; i < 5; i++) {
                this.hand.Add(deck.Deal());
            }
            return this.hand;
        }

        public Card Discard(int idx) {
            if(idx < 0 || idx > this.hand.Count-1) {
                System.Console.WriteLine("Invalid card");
                return null;
            } else {
                Card discardedCard = this.hand[idx];
                this.hand.RemoveAt(idx);
                return discardedCard;
            }
        }
    }
}