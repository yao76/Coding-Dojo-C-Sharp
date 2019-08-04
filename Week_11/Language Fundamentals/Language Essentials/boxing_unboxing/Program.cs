using System;
using System.Collections.Generic;


namespace boxing_unboxing
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an empty List of type object
            List<object> objList = new List<object>();

            // Add the following values to the list: 7, 28, -1, true, "chair"
            objList.Add(7);
            objList.Add(28);
            objList.Add(-1);
            objList.Add(true);
            objList.Add("chair");
            int sum = 0;

            // Loop through the list and print all values (Hint: Type Inference might help here!)
            foreach (var obj in objList)
            {
                System.Console.WriteLine(obj);
                
                // Add all values that are Int type together and output the sum
                if (obj is int)
                {
                    int actuallyInt = (int) obj;
                    sum += actuallyInt;
                }
            }
            System.Console.WriteLine(sum);
        }
    }
}
