using System;
using System.Collections.Generic;
using System.Linq;

namespace puzzles
{
    static class Program
    {
        static void Main(string[] args)
        {
            RandomArray();
            TossCoin();
            TossMultipleCoins(3);
            Names();
        }

        //Create a function called RandomArray() that returns an integer array
        // Place 10 random integer values between 5-25 into the array
        // Print the min and max values of the array
        // Print the sum of all the values
        public static int[] RandomArray()
        {
            int[] randArr = new int[10];

            Random randNum = new Random();
            for (int i = 0; i < randArr.Length; i++)
            {
                randArr[i] = randNum.Next(5, 26);
            }

            int min = randArr[0];
            int max = randArr[0];
            int sum = 0;
            foreach (var num in randArr)
            {
                if (num > max)
                {
                    max = num;
                }
                if (num < min)
                {
                    min = num;
                }

                sum += num;
            }

            System.Console.WriteLine($"Min: {min} Max: {max} Sum: {sum}");
            Console.WriteLine(string.Join(", ", randArr));
            return randArr;
        }

        // Create a function called TossCoin() that returns a string

        // Have the function print "Tossing a Coin!"
        // Randomize a coin toss with a result signaling either side of the coin 
        // Have the function print either "Heads" or "Tails"
        // Finally, return the result

        public static string TossCoin()
        {
            System.Console.WriteLine("Tossing a Coin!");
            Random randNum = new Random();
            int num = randNum.Next(2);
            string result = "";
            if (num == 0)
            {
                result = "Heads";
            }
            else
            {
                result = "Tails";
            }
            System.Console.WriteLine(result);
            return result;

        }

        // Create another function called TossMultipleCoins(int num) that returns a Double
        // Have the function call the tossCoin function multiple times based on num value
        // Have the function return a Double that reflects the ratio of head toss to total toss

        public static double TossMultipleCoins(int num)
        {
            double ratio = 0;
            int headCount = 0;
            int tailCount = 0;
            string[] results = new string[num];
            for (int i = 0; i < num; i++)
            {
                results[i] = TossCoin();
            }

            foreach (var res in results)
            {
                if (res == "Heads")
                {
                    headCount++;
                }
                else
                {
                    tailCount++;
                }

                ratio = headCount / (double)(headCount + tailCount);
            }
            System.Console.WriteLine($"Head Count: {headCount} Tail Count: {tailCount} Ratio: {ratio}");
            return ratio;
        }

        // Build a function Names that returns a list of strings.  In this function:
        // Create a list with the values: Todd, Tiffany, Charlie, Geneva, Sydney
        // Shuffle the list and print the values in the new order
        // Return a list that only includes names longer than 5 characters

        // Fisher Yates shuffle
        public static IList<T> Shuffle<T>(this IList<T> list)
        {
            int n = list.Count;
            Random rnd = new Random();
            while (n > 1)
            {
                int k = (rnd.Next(0, n) % n);
                n--;
                T value = list[k];
                list[k] = list[n];
                list[n] = value;
            }
            return list;
        }
        public static List<string> Names()
        {

            List<string> nameList = new List<string>();
            nameList.Add("Todd");
            nameList.Add("Tiffany");
            nameList.Add("Charlie");
            nameList.Add("Geneva");
            nameList.Add("Sydney");
            
            // Shuffle using LINQ
            // var rand = new Random();
            // var randomList = nameList.OrderBy(x => rand.Next()).ToList(); 

            var randomList = Shuffle(nameList);


            Console.WriteLine(string.Join(", ", randomList));

            // Build new list with all names with 5 or more characters
            List<string> newNameList = new List<string>();
            foreach (var name in randomList)
            {
                if (name.Length >= 5)
                {
                    newNameList.Add(name);
                }
            }
            Console.WriteLine(string.Join(", ", newNameList));
            return newNameList;

        }
    }
}
