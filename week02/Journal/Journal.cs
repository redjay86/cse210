using System.IO;
public class Journal()
{
    List<Entry> _entries = new List<Entry>();
    public bool _changesSaved = true;

    public void AddEntry(Entry newEntry)
    {
        _changesSaved = false;
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (Entry entry in _entries)
        {
            entry.Display();
            Console.WriteLine();
        }
    }
    public void SaveToFile(string fileName)
    {
        _changesSaved = true;
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"{entry._date},{entry._entryText},{entry._promptText}");
            }
        }
    }

    public void LoadFromFile(string fileName)
    {
        string[] lines = System.IO.File.ReadAllLines(fileName);
        _entries = new List<Entry>();
        foreach (string line in lines)
        {
            string[] parts = line.Split(",");
            Entry entry = new Entry();
            entry._date = parts[0];
            entry._entryText = parts[1];
            entry._promptText = parts[2];
            _entries.Add(entry);
        }
    }
}