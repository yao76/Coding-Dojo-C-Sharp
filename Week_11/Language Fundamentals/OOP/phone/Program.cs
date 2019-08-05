using System;

namespace phone
{
    class Program
    {
        static void Main(string[] args)
        {
            Nokia elevenHundred = new Nokia("1100", 100, "T-Mobile", "Dooo do do do doo do do do doo do do do do");
            Galaxy s8 = new Galaxy("s8", 50, "Sprint", "Riinnnggg Riiiiinggg Riiiinggg");

            s8.DisplayInfo();
            System.Console.WriteLine("");

            System.Console.WriteLine(s8.Ring());
            System.Console.WriteLine(s8.Unlock());
            System.Console.WriteLine("");

            elevenHundred.DisplayInfo();
            System.Console.WriteLine("");
            System.Console.WriteLine(elevenHundred.Ring());
            System.Console.WriteLine(elevenHundred.Unlock());
        }
    }
}
