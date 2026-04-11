using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Start Breathing Activity");
        Console.WriteLine("2. Start Reflecting Activity");
        Console.WriteLine("3. Start Listing Activity");
        Console.WriteLine("4. Exit");
        Console.WriteLine("Please select from one of the following menu options: ");
        string userOption = Console.ReadLine();
        int selectedOption = int.Parse(userOption);
        while (!(selectedOption == 4))
        {
            if (selectedOption == 1)
            {
                Activity breathing = new Activity("Breathing Activity", "In this activity you will breath in and out slowly once you relax your thoughts and breathe.", 10);
                breathing.DisplayStartingMessage();
                Console.WriteLine();
                Console.WriteLine(breathing.GetDescription());
            }
            else if (selectedOption == 2)
            {
            }
            else if (selectedOption == 3)
            {
            }
            else
            {
                Console.WriteLine("Come back soon! ");
            }
        }
    }
}
