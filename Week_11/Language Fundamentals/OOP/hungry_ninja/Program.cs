using System;

namespace hungry_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buff1 = new Buffet();

            Ninja ninja1 = new Ninja("Eric");
            while(ninja1.IsFull() == false) {
                ninja1.Eat(buff1.Serve());
            }
            System.Console.WriteLine($"{ninja1.Name}'s food history: ");
            foreach(var food in ninja1.FoodHistory) {
                System.Console.WriteLine(food.Name);
            }
            
        }
    }
}
