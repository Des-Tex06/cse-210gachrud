using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _startVerse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = "John";
        _chapter = 3;
        _verse = 16;

    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = "Proverbs";
        _chapter = 3;
        _startVerse = 5;
        _endVerse = 6;
    }

    public string GetDisplayText()
    {
        return "";
    }
}