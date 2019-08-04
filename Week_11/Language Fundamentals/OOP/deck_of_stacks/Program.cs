using System;

namespace deck_of_stacks
{
    class Program
    {
        static void Main(string[] args)
        {
            Deck d1 = new Deck();
            d1.shuffle();
            Player p1 = new Player("Eric");
            Player p2 = new Player("Bob");
            p1.Draw(d1);
            p2.Draw(d1);
            d1.shuffle();
            
            p1.Discard(4);
            // d1.Reset();
            // System.Console.WriteLine(d1.cards.Count);

        }
    }
}
