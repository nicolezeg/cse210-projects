using System;
public class Journal 
{
    
    List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }

    public void AddEntry(Entry newEntry)
    {
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        foreach (var entry in _entries)
        {
            entry.Display();
        }
    }

    public void SaveToFile(string file)
    {
        using (var writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine($"{entry._dates},{entry._promptText},{entry._entryText}");
            }
        }
    }

    public void LoadFromFile(string file)
    {
        _entries = new List<Entry>();
        using (var reader = new StreamReader(file))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                var parts = line.Split(',');
                _entries.Add(new Entry
                {
                    _dates = parts[0],
                    _promptText = parts[1],
                    _entryText = parts[2]
                });
            }
        }
    }
}