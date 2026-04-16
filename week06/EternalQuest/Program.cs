using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Menu");
        Console.WriteLine("1. Create New Goal");
        Console.WriteLine("2. List Goals");
        Console.WriteLine("3. Save Goals");
        Console.WriteLine("4. Load Goals");
        Console.WriteLine("5. Record Event");
        Console.WriteLine("6. Quit");
        Console.Write("Please select an option from the menu: ");
        string userOption = Console.ReadLine();
        int selectedOption = int.Parse(userOption);
        while (!(selectedOption == 6))
        {
            if (selectedOption == 1)
            {
                Console.WriteLine("Types of Goals:");
                Console.WriteLine("1. Simple Goal");
                Console.WriteLine("2. Eternal Goal");
                Console.WriteLine("3. Checklist Goal");
                Console.WriteLine("4. Return to Menu");
                Console.Write("Select type of Goal to create: ");
                string goalOption = Console.ReadLine();
                int selectedGoal = int.Parse(goalOption);
                while (!(selectedGoal == 4))
                {   
                    if (selectedGoal == 1)
                    {

                        Console.Write("Type in name of your goal: ");
                        string _name = Console.ReadLine();
                        Console.WriteLine("Write a brief description of your goal: ");
                        string _description = Console.ReadLine();
                        Console.WriteLine("Enter amount of points for your goal when completed: ");
                        string _points = Console.ReadLine();
                        GoalManager simpleGoal = new GoalManager();
                        SimpleGoal goalStrings = new SimpleGoal(_name, _description, _points);
                        simpleGoal._goals.Add(goalStrings);


                    }
                    else if (selectedGoal == 2)
                    {
                        Console.Write("Type in name of your goal: ");
                        string _name = Console.ReadLine();
                        Console.WriteLine("Write a brief description of your goal: ");
                        string _description = Console.ReadLine();
                        Console.WriteLine("Enter amount of points for your goal when completed: ");
                        string _points = Console.ReadLine();
                        GoalManager eternalGoal = new GoalManager();
                        EternalGoal goalStrings = new EternalGoal(_name, _description, _points);
                        eternalGoal._goals.Add(goalStrings);

                    }
                    else if (selectedGoal == 3)
                    {}
                    else if (selectedGoal == 4)
                    {
                        Console.WriteLine("Menu");
                        Console.WriteLine("1. Create New Goal");
                        Console.WriteLine("2. List Goals");
                        Console.WriteLine("3. Save Goals");
                        Console.WriteLine("4. Load Goals");
                        Console.WriteLine("5. Record Event");
                        Console.WriteLine("6. Quit");
                        Console.Write("Please select an option from the menu: ");



                    }
                }
            }
            else if (selectedOption == 2)
            {
    
            }
            else if (selectedOption == 3)
            {
            }
            else if (selectedOption == 4)
            {
                
            }
            else if (selectedOption == 5)
            {}
            else
            {
                Console.WriteLine("Come back soon! ");
            }
        }
    }
}