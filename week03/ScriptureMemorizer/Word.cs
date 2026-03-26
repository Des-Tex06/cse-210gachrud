using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    public Word(string text)
    {
        return;
    }
    
    public void Hide()
    {
        
        // This will start by displaying "AAA" and waiting for the user to press the enter key
        Console.WriteLine(_text);
        Console.ReadLine();

        // This will clear the console
        Console.Clear();

        // This will show "BBB" in the console where "AAA" used to be
        Console.WriteLine("___");

    }

    public void Show()
    {
        
    }

    public bool IsHidden()
    {
        return _isHidden;
    }

    public string GetDisplayText()
    {
        return "";
    }
}
