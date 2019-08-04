using System;

namespace iron_ninja
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buff1 = new Buffet();

            SweetTooth sw = new SweetTooth();
            while (sw.IsFull == false)
            {
                sw.Consume(buff1.Serve());
            }
            System.Console.WriteLine("SweetTooth's food history: ");
            Console.WriteLine("{0,-25} {1,5}\n", "Food Name", "Food Calories");
            foreach (var food in sw.ConsumptionHistory)
            {
                System.Console.WriteLine("{0,-25} {1,5:N0}", food.Name, food.Calories);
            }

            System.Console.WriteLine($"Sweet Tooth ate {sw.CalorieAmount} calories. Ninja is too full to eat anymore.");


            System.Console.WriteLine("----------------------------------------------------------------");

            SpiceHound sp = new SpiceHound();
            while (!sp.IsFull)
            {
                sp.Consume(buff1.Serve());
            }

            System.Console.WriteLine("Spicehound's food history: ");
            Console.WriteLine("{0,-25} {1,5}\n", "Food Name", "Food Calories");
            foreach (var food in sp.ConsumptionHistory)
            {
                System.Console.WriteLine("{0,-25} {1,5:N0}", food.Name, food.Calories);
            }

            System.Console.WriteLine($"Spice Hound ate {sp.CalorieAmount} calories. Ninja is too full to eat anymore.");

            System.Console.WriteLine("----------------------------------------------------------------");

            System.Console.WriteLine($"Sweet Tooth consumed {sw.ConsumptionHistory.Count} items. Spice Hound consumed {sp.ConsumptionHistory.Count} items");
            
            string winner = (sw.ConsumptionHistory.Count>sp.ConsumptionHistory.Count) ? "Sweet Tooth" : (sw.ConsumptionHistory.Count==sp.ConsumptionHistory.Count)? "Nobody" :"Spice Hound";

            System.Console.WriteLine($"{winner} ate the most items!");
        }
    }
}
