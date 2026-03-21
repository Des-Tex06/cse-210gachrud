using System;

public class Entry
{ 
    static DateTime theCurrentTime = DateTime.Now;
    string _date = theCurrentTime.ToShortDateString();         
    public string _promptText;
    public string _entryText;

    public void Display()
    {
        Console.WriteLine($"{_date} {_promptText}");
        Console.WriteLine($"{_entryText}");

    }
}