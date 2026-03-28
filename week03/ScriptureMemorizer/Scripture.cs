using System;
using System.Security;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word>_words = new List<Word>();

    Scripture (Reference reference, string text)
    {
        _reference = reference;
        text = foreach (Word _word in _words)
        {
            Console.WriteLine(_word);
        }


    }
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        numberToHide = 0;
        int positionToHide = 0;
        while (numberToHide.Count)
        {
            positionToHide = random.Next(0,_words.Count);
            if _words = 
            {
                
            }
        }
    }
    public string GetDisplayText()
    {
        Console.WriteLine();
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}