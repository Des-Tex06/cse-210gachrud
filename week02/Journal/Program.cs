using System;
class Program
{
    static void Main(string[] args)
    {   Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1. Write Journal Entry");
        Console.WriteLine("2. Display Journal");
        Console.WriteLine("3. Save Journal");
        Console.WriteLine("4. Load Journal");
        Console.WriteLine("5. Exit");
        Console.Write("Which option would you like to select?: ");
        string userOption = Console.ReadLine();
        int selectedOption = int.Parse(userOption);
        while (!(selectedOption == 5)) 
            {
                if (selectedOption == 1)
                {
                    PromptGenerator journalprompt = new PromptGenerator();
                    journalprompt.GetRandomPrompt();
                }
                else if (selectedOption == 2)
                {
                    Journal journal2 = new Journal();
                    journal2.DisplayAll();
                }
                else if (selectedOption == 3)
                {
                    
                }
                else if (selectedOption == 4)
                {
                }
                else
                {
                    Console.WriteLine("Hasta La Vista Baby!");
                }
            }
    }
}