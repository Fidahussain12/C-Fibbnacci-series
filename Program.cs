using System;

internal class Program
{
    static void Main()
    {
        int FirstNumber = 0, SecondNumber = 1, NextNumber, NoElements;

        // Read the number of elements for the Fibonacci series
        NoElements = Convert.ToInt32(Console.ReadLine());

        if (NoElements < 2)
        {
            Console.WriteLine("Element Should Start from 2 or Above");
        }
        else
        {
            // Print the first two numbers in the series
            Console.Write(FirstNumber + " " + SecondNumber + " ");

            for (int i = 2; i < NoElements; i++)
            {
                // Calculate the next number in the series
                NextNumber = FirstNumber + SecondNumber;

                // Print the next number
                Console.Write(NextNumber + " ");

                // Update FirstNumber and SecondNumber for the next iteration
                FirstNumber = SecondNumber;
                SecondNumber = NextNumber;
            }
        }
    }
}
