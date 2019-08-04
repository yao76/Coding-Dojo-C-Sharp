using System;

namespace basic13
{
    class Program
    {
        static void Main(string[] args)
        {
            // PrintNumbers();
            // PrintOdds();
            // PrintSum();
            // LoopArray(new int[] {199, 2200, 1, 3, 40});
            // FindMax(new int[] {0,-1,200,-1000,50});
            // GetAverage(new int[] { 2, 10, 4 });
            // OddArray();
            // GreaterThanY(new int[] { 2, 10, 3, 1 }, 1);
            // SquareArrayValues(new int[] { 2, 10, 3, 1 });
            // EliminateNegatives(new int[] { -1, -5, 100, -2, -3, 4, 1 });
            // MinMaxAverage(new int[] {1, 5, 10, -2});
            // ShiftValues(new int[] { 1, 2, 3, 4, 5 });
            NumToString(new int[] {-1, -3, 2});
        }


        // Print all of the integers from 1 to 255.
        public static void PrintNumbers()
        {
            for (int i = 1; i <= 255; i++)
            {
                System.Console.WriteLine(i);
            }

        }
        // Print all odd integers from 1 to 255.
        public static void PrintOdds()
        {
            // Print all of the odd integers from 1 to 255.
            for (int i = 1; i <= 255; i++)
            {
                if (i % 2 == 1)
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        // Print all of the numbers from 0 to 255, 
        // but this time, also print the sum as you go.  
        public static void PrintSum()
        {
            int sum = 0;
            for (int i = 1; i <= 255; i++)
            {
                sum += i;
                System.Console.WriteLine("New number: " + i + " Sum: " + sum);
            }
        }

        // Write a function that would iterate through each item of the given integer array and 
        // print each value to the console. 
        public static void LoopArray(int[] numbers)
        {
            foreach (var num in numbers)
            {
                System.Console.WriteLine(num);
            }
        }

        // Write a function that takes an integer array and prints and returns the maximum value in the array. 
        // Your program should also work with a given array that has all negative numbers (e.g. [-3, -5, -7]), 
        // or even a mix of positive numbers, negative numbers and zero.
        public static int FindMax(int[] numbers)
        {

            int max = numbers[0];
            foreach (var num in numbers)
            {
                if (num > max)
                {
                    max = num;
                }
            }
            System.Console.WriteLine($"Max: {max}");
            return max;
        }


        // Write a function that takes an integer array and prints the AVERAGE of the values in the array.
        // For example, with an array [2, 10, 3], your program should write 5 to the console.
        public static void GetAverage(int[] numbers)
        {
            int sum = 0;
            foreach (var num in numbers)
            {
                sum += num;
            }

            float avg = (float)sum / numbers.Length;
            System.Console.WriteLine(avg);
        }

        // Write a function that creates, and then returns, an array that contains all the odd numbers between 1 to 255. 
        // When the program is done, this array should have the values of [1, 3, 5, 7, ... 255].
        public static int[] OddArray()
        {

            int[] oddArr = new int[128];
            for (int i = 0; i <= 127; i++)
            {
                oddArr[i] = 2 * i + 1;
            }
            System.Console.WriteLine(oddArr);
            return oddArr;
        }


        // Write a function that takes an integer array, and a integer "y" and returns the number of array values 
        // That are greater than the "y" value. 
        // For example, if array = [1, 3, 5, 7] and y = 3. Your function should return 2 
        // (since there are two values in the array that are greater than 3).
        public static int GreaterThanY(int[] numbers, int y)
        {
            int count = 0;
            foreach (var num in numbers)
            {
                if (num > y)
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
            return count;
        }

        // Write a function that takes an integer array "numbers", and then multiplies each value by itself.
        // For example, [1,5,10,-10] should become [1,25,100,100]
        public static void SquareArrayValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] *= numbers[i];
            }
            System.Console.WriteLine(numbers);
        }


        // Given an integer array "numbers", say [1, 5, 10, -2], create a function that replaces any negative number with the value of 0. 
        // When the program is done, "numbers" should have no negative values, say [1, 5, 10, 0].
        public static void EliminateNegatives(int[] numbers)
        {
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] < 0)
                {
                    numbers[i] = 0;
                }
            }
            System.Console.WriteLine(numbers);
        }


        // Given an integer array, say [1, 5, 10, -2], create a function that prints the maximum number in the array, 
        // the minimum value in the array, and the average of the values in the array.
        public static void MinMaxAverage(int[] numbers)
        {
            int max = numbers[0];
            int min = numbers[0];
            int sum = 0;
            foreach (var num in numbers)
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

            float avg = (float)sum / numbers.Length;
            System.Console.WriteLine($"Max: {max} Min: {min} Sum: {sum} Length: {numbers.Length} Avg: {avg}");
        }

        // Given an integer array, say [1, 5, 10, 7, -2], 
        // Write a function that shifts each number by one to the front and adds '0' to the end. 
        // For example, when the program is done, if the array [1, 5, 10, 7, -2] is passed to the function, 
        // it should become [5, 10, 7, -2, 0].
        public static void ShiftValues(int[] numbers)
        {
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                numbers[i] = numbers[i + 1];
            }
            numbers[numbers.Length - 1] = 0;
            System.Console.WriteLine(numbers);
        }


        // Write a function that takes an integer array and returns an object array 
        // that replaces any negative number with the string 'Dojo'.
        // For example, if array "numbers" is initially [-1, -3, 2] 
        // your function should return an array with values ['Dojo', 'Dojo', 2].
        public static object[] NumToString(int[] numbers)
        {
            object[] result = new object[numbers.Length];
            for(var i = 0; i < numbers.Length; i++) {
                if(numbers[i] < 0) {
                    result[i] = "Dojo";
                } else {
                    result[i] = numbers[i];
                }
            }

            System.Console.WriteLine(result);
            return result;
        }
    }
}
