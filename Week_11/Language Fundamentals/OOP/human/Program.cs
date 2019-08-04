using System;

namespace human
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("Bob");
            Human eric = new Human("Eric");
            System.Console.WriteLine($"Bob's health before attack: {bob.getHealth()}");
            System.Console.WriteLine($"Eric's strength: {eric.Strength}");
            eric.Attack(bob);
            System.Console.WriteLine($"Bob's health after attack: {bob.getHealth()}");
        }
    }
}
