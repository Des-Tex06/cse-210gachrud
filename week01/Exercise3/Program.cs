using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello World! This is the Exercise3 Project.");
        Console.WriteLine();
        //The lines of code from 11-13 were from the 
        //two previous steps in this activity.
        //Console.Write("What is the magic number? ");
        //string userMagicNumber = Console.ReadLine();
        //int magicNumber = int.Parse(userMagicNumber);
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1,100);
        Console.Write("What is your guess? ");
        string userGuess = Console.ReadLine();
        int numberGuess = int.Parse(userGuess);
        while (!(numberGuess == magicNumber))
            {
                if (numberGuess < magicNumber)
                {
                    Console.WriteLine("Higher");
                    Console.Write("What is your guess? ");
                    userGuess = Console.ReadLine();
                    numberGuess = int.Parse(userGuess);
                }
                else if (numberGuess > magicNumber)
                {
                    Console.WriteLine("Lower");
                    Console.Write("What is your guess? ");
                    userGuess = Console.ReadLine();
                    numberGuess = int.Parse(userGuess);
                }
            }
        Console.WriteLine("You guessed it!");
    }
}