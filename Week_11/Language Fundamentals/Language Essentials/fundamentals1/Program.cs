using System;

namespace fundamentals1
{
    class Program
    {
        static void Main(string[] args)
        {
            //print all values between 1 and 255
            for (int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }


            // Create a new loop that prints all values from 1-100 that are divisible by 3 or 5, but not both
            for (int i = 1; i <= 100; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    continue;
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine(i);
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine(i);
                }
            }


            // // Modify the previous loop to print "Fizz" for multiples of 3, "Buzz" for multiples of 5, and "FizzBuzz" for numbers that are multiples of both 3 and 5
            // for (int i = 1; i <= 100; i++)
            // {
            //     if (i % 3 == 0 && i % 5 == 0)
            //     {
            //         System.Console.WriteLine("FizzBuzz");
            //     }
            //     else if (i % 3 == 0)
            //     {
            //         System.Console.WriteLine("Fizz");
            //     }
            //     else if (i % 5 == 0)
            //     {
            //         System.Console.WriteLine("Buzz");
            //     }

            //     else {
            //         System.Console.WriteLine(i);
            //     }
            // }

            // // do the last problem using a while loop
            // int a = 1;
            // while(a<=100) {
            //     if (a % 3 == 0 && a % 5 == 0)
            //     {
            //         System.Console.WriteLine("FizzBuzz");
            //     }
            //     else if (a % 3 == 0)
            //     {
            //         System.Console.WriteLine("Fizz");
            //     }
            //     else if (a % 5 == 0)
            //     {
            //         System.Console.WriteLine("Buzz");
            //     }

            //     else {
            //         System.Console.WriteLine(a);
            //     }

            //     a++;
            // }


        }
    }
}
