using System;
using System.Linq;

namespace SumOfDigits
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            // Declare Variables
            int sum = 0;

            // Print instructions to console
            Console.WriteLine("Sum Of Digits");
            Console.WriteLine("Enter Number: ");

            // Collect input from console into String
            string input = Console.ReadLine();

            // Convert String to an array of Int
            var intArray = input.Select(c => c - '0').ToArray();

            // Sum up the numbers in the array
            for(int i = 0; i <= intArray.Length - 1; i++)
            {
                sum += intArray[i];
            }

            // Print the answer
            Console.WriteLine("The sum of the digits in: " + input + " is: " + sum);

        }
    }
}
