using System.IO;
public class Journal
{   
    string filename = "journal_entries.txt";
    public List<Entry> _entries;
    string newEntry = "";

    public string AddEntry()
    {   
        string filename = "journal_entries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))

        outputFile.Write("Entry: ");

        return "";

    }
    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
        }
    }
    public void SaveToFile(string file)
    {
        Console.Write("Enter name of the file: ");
        file = Console.ReadLine();
        if (file == "journal_entries.txt")
        {
            using (StreamWriter sw = File.CreateText("journal_entries.txt"))
            {
                sw.WriteLine("Entry saved.");
            }
            
        }
        
        
    }
    public void LoadFromFile(string file)
    {
    string filename = "journal_entries.txt";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string prompt = parts[0];
            string entry = parts[1];
        }
    }
    
}   