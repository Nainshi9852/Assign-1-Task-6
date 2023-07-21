using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Declare an integer array with five elements
            int[] numbers = new int[5];

            // Initialize the array 
            numbers[0] = 10;
            numbers[1] = 20;
            numbers[2] = 30;
            numbers[3] = 40;
            numbers[4] = 50;

            //Display the array elements
            Console.WriteLine("Array Elements:");
            foreach(int num in numbers)
            {
                Console.WriteLine(num);
            }
            // Calculate the sum of the elements in the array
            int sum = 0;
            foreach (int num in numbers)
            {
                sum += num;
            }

            // Calculate the average of the elements in the array
            double average = (double)sum / numbers.Length;

            // Display the sum and average 
            Console.WriteLine("Sum of the elements: " + sum);
            Console.WriteLine("Average of the elements: " + average);
            Console.ReadKey();
        }
    }
}
