using System;

class Program
{
    
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise2 Project.");
        Console.WriteLine();
        Console.Write("What is your grade percentage? ");
        string userGradePercentage = Console.ReadLine();
        int number = int.Parse(userGradePercentage);

        string letter = "";

        if (number >= 90)
        {
            letter = "A";
        }
        else if (number >= 80)
        {
            letter = "B";
        }
        else if (number >= 70)
        {
            letter = "C"; 
        }
        else if (number >= 60)
        {
            letter = "D";
        }
        else if (number < 60)
        {
            letter = "F";
        }
        if (number >= 70)
        {
            Console.WriteLine($"Since your grade is {letter},");
            Console.WriteLine("You have passed the Course!");
            Console.WriteLine();
            Console.WriteLine("Congratulations!");
        }
        else
        {
            Console.WriteLine($"Since your grade is {letter},");
            Console.WriteLine("You did not pass the course.");
            Console.WriteLine();
            Console.WriteLine("Keep trying and pass next time!");
        }
    }
}