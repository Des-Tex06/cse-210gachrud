using System.IO;
using System.Collections.Generic;

public class PromptGenerator
{   public List<PromptGenerator> _prompts = new List<PromptGenerator>();
    
    public string GetRandomPrompt()
    {   
        foreach (PromptGenerator _prompt in _prompts)
        {
            Console.Write(_prompt);
        }
        return "";
        
    }

}