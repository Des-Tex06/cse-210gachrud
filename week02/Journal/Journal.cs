using System.IO;
public class Journal
{   
    string filename = "journal_entries.txt";
    public List<Entry> _entries;
    string newEntry;
    public void AddEntry(Entry newEntry)
    {
        string filename = "journal_entries.txt";

        using (StreamWriter outputFile = new StreamWriter(filename))

        outputFile.Write("Entry: ");
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
        
        if (file == "journal_entries.txt")
        {
            
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