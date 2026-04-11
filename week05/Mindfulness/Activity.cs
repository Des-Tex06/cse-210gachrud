class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description, int duration)
    {
        _name = name;
        _description = description;
        _duration = duration;
    }

    public string GetName()
    {
        return _name;
    }
    public void SetName(string name)
    {
        _name = name; 
    }

    public string GetDescription()
    {
        return _description;
    }
    public void SetDescription(string description)
    {
        _description = description;
    }

    public int GetDuration()
    {
        return _duration;
    }
    public void SetDuration(int duration)
    {
        _duration = duration;
    }

    public void DisplayStartingMessage()
    {
        Console.WriteLine($"Welcome to the {_name} Activity");
    }
    public void DisplayEndingMessage()
    {
        Console.WriteLine("Excellent job!");
        Console.WriteLine();
        Console.WriteLine($"You completed {_duration} seconds of the {_name} Activity!");
    }
    public void ShowSpinner(int seconds)
    {
        List<string> animeStrings = new List<string>();
        animeStrings.Add("|");
        animeStrings.Add("/");
        animeStrings.Add("-");
        animeStrings.Add("\\");
        animeStrings.Add("|");
        animeStrings.Add("/");
        animeStrings.Add("-");
        animeStrings.Add("\\");

        foreach (string str in animeStrings)
        {
            Console.Write(str);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("Finished");
    }
    public void ShowCountDown(int seconds)
    {
        for (int i = 10; i > 0; i--)
        {
            Console.Write(i);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }

        Console.WriteLine("Finished");
    }
}