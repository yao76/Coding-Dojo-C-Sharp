using System;
namespace deck_of_stacks
{
    public class Card
    {
        // private string suit;
        private string suit;

        // private string str_val;
        private string str_val;

        // private int val;
        private int val;

        public Card(string suit, string str_val, int val ) {
            this.suit = suit;
            this.str_val = str_val;
            this.val = val;
        }
    }

    
}