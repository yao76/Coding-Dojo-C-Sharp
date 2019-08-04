using System;

namespace wizard_ninja_samurai
{
    class Program
    {
        static void Main(string[] args)
        {
            Human bob = new Human("Bob");
            System.Console.WriteLine(bob); 
            Ninja zuko = new Ninja("Zuko");
            System.Console.WriteLine(zuko);
            Samurai jack = new Samurai("Jack");
            System.Console.WriteLine(jack);
            Wizard gandalf = new Wizard("Gandalf");
            System.Console.WriteLine(gandalf);

            gandalf.Attack(jack);
            System.Console.WriteLine(gandalf);
            System.Console.WriteLine(jack);

            gandalf.Heal(gandalf);
            System.Console.WriteLine(gandalf);
        }
    }
}
