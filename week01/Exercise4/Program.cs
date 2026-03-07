using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise4 Project.");
        Console.WriteLine();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        List<int> numbers = new List<int>();
        Console.Write("Enter Number: ");
        string enteredNumber = Console.ReadLine();
        int addedNumber = int.Parse(enteredNumber);
        numbers.Add(addedNumber);
        while (!(addedNumber == 0))
        {
            Console.Write("Enter Number: ");
            enteredNumber = Console.ReadLine();
            addedNumber = int.Parse(enteredNumber);
            if (addedNumber != 0)
            {
                numbers.Add(addedNumber);
            }   
        }
        int numberSum = 0;
        foreach (int number in numbers)
        {
            numberSum += number;
        }
        Console.WriteLine($"The sum is: {numberSum}");
        float numberAverage = ((float)numberSum) / numbers.Count;
        Console.WriteLine($"The average is {numberAverage}");
        int max = 0;
        foreach (int number in numbers)
        {
            if (number > max)
            {
                max = number;
            }
        }
        Console.WriteLine($"The max is: {max}");
    }

}