public class PromptGenerator
{   public List<string> _prompts = new List<string>();

    public string GetRandomPrompt()
    {   
        var random = new Random();
        _prompts = ["What was your favorite meal today?", "Write about one accomplishment you made today.", 
        "Name one hobby that helped distress you.","What could you have done better?",
        "What are you looking forward to tomorrow?","What hobby did you do today?"];
        int index = random.Next(_prompts.Count);
        Console.WriteLine(_prompts[index]);
        return "";
        
    }

} 