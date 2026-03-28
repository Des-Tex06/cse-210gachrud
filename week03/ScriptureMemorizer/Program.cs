using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //Reference ref1 = new Reference("John", 3, 16);
        //ref1.GetDisplayText();
        Reference ref2 = new Reference("Proverbs", 3, 5, 6);
        ref2.GetDisplayText();
        Word verse1 = new Scripture("Trust", "in", "the", "LORD", "with", "all", 
        "thine", "heart", "and", "lean", "not", "unto", "thine", "own", "understanding.");
        Word verse2 = new Scripture("In", "all", "thy", "ways", "acknowledge", "him",
        "and", "he", "shall", "direct", "thy", "paths.");
        Console.Write("Press enter to hide the words of the scripture or type in 'quit': ");
        string option = Console.ReadLine();
        while (option != "quit")
        {
            
        }
    }
}