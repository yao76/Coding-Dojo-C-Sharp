using System;
using System.Collections.Generic;


namespace collections_practice
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create an array to hold integer values 0 through 9
            int[] myArray = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            // Create an array of the names "Tim", "Martin", "Nikki", & "Sara"
            string[] nameArray = { "Tim", "Martin", "Nikki", "Sara" };

            // Create an array of length 10 that alternates between true and false values, starting with true
            bool[] boolArray = { true, false, true, false, true, false, true, false, true, false };

            // Create a list of ice cream flavors that holds at least 5 different flavors (feel free to add more than 5!)
            List<string> flavors = new List<string>();
            flavors.Add("mint");
            flavors.Add("vanilla");
            flavors.Add("chocolate");
            flavors.Add("oreo");
            flavors.Add("fudge");

            //Output the length of this list after building it
            Console.WriteLine(flavors.Count); 

            Console.WriteLine(flavors[2]); //Output the third flavor in the list, then remove this value
            flavors.RemoveAt(2);

            //Output the new length of the list (It should just be one fewer!)
            Console.WriteLine(flavors.Count); 


            // Create a dictionary that will store both string keys as well as string values
            Dictionary<string, string> favFlavors = new Dictionary<string, string>();
            Random random = new Random();

            // Add key/value pairs to this dictionary where: each key is a name from your names array, each value is a randomly select a flavor from your flavors list.
            for (int i = 0; i < nameArray.Length; i++)
            {
                int flaveNum = random.Next(flavors.Count);
                System.Console.WriteLine($"flavNum: {flaveNum}");
                favFlavors.Add(nameArray[i], flavors[flaveNum]);
            }

            // Loop through the dictionary and print out each user's name and their associated ice cream flavor
            foreach (var entry in favFlavors)
            {
                Console.WriteLine(entry.Key + " - " + entry.Value);
            }


        }
    }
}
