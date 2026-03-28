using System;

class Program
{
    static void Main(string[] args)
    {
        //Reference ref1 = new Reference("John", 3, 16);
        //ref1.GetDisplayText();
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        ref2.GetDisplayText();
        Word word1 = new Word("Trust in the LORD with all thine heart and lean not unto thine own understanding.");
        word1.GetDisplayText();
        Console.Write("Press enter to hide the words of the scripture or type in 'quit': ");
        string option = Console.ReadLine();
        while (option != "quit")
        {
            
        }
    }
}