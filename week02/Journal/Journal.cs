using System.IO;

public class Journal
{   
    public List<Entry> _entries;
    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
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
        
        if (file == "entries.txt")
        {
            
        }
    }
    public void LoadFromFile(string file)
    {
    string filename = "";
    string[] lines = System.IO.File.ReadAllLines(filename);

    foreach (string line in lines)
        {
            string[] parts = line.Split(",");

            string prompt = parts[0];
            string entry = parts[1];
        }
    }
    
}   