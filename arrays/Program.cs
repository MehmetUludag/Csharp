using System;

namespace arrays
{
    
    class Program
    {
        
        static void Main(string[] args)
        {

            // Array Definition

            string[] colours = new string[5];
            string[] animals = {"Cat", "Dog", "Bird", "Elephant"};

            int[] arr;
            arr = new int[5];


            // Assigning Values to Arrays

            colours[0] = "Blue";
            arr[3] = 10;

            Console.WriteLine(colours[0]);
            Console.WriteLine(animals[1]);
            Console.WriteLine(arr[3]);


            // Using Arrays with Loops
            // Program that calculates the average of n numbers entered from the keyboard

            Console.Write("Please enter the number of elements of the array: ");
            int arrLength = int.Parse(Console.ReadLine());
            int[] numArray = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
            {
                Console.Write("Please Enter {0}. Number: ", i+1);
                numArray[i] = int.Parse(Console.ReadLine()); 
            }

            int total = 0;
            foreach (var num in numArray)
            {
                total += num;
            }

            Console.WriteLine("Average: " + total/arrLength);

        }
    }
}