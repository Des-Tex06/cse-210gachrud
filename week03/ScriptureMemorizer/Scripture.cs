using System;
using System.Security;

public class Scripture
{
    private Reference _reference;
    private List<Word>_words = new List<Word>();

    Scripture (Reference reference, string text)
    {
        _reference = reference;

    }
    public void HideRandomWords(int numberToHide)
    {
        
    }
    public string GetDisplayText()
    {
        return "";
    }

    public bool IsCompletelyHidden()
    {
        return true;
    }
}