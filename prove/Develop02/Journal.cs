public class Journal
{
    public List<Entry> _entries;

    public Journal()
    {
        _entries = new List<Entry>();
    }
    public void AddEntry (Entry newEntry)
    {
        _entries.Add(newEntry);

    }

    public void DisplayAll()
    {
        if (_entries.Count == 0)
        {
            Console.WriteLine("No Journal entry available.");
        }
        else
        {
            foreach (var entry in  _entries)
            {
                entry.Display();
            }
        }

    }

    public void SaveToFile (string file)
    {
        using (StreamWriter writer = new StreamWriter(file))
        {
            foreach (var entry in _entries)
            {
                writer.WriteLine(entry._date);
                writer.WriteLine(entry._promptText);
                writer.WriteLine(entry._entryText);
            }
        }
        Console.WriteLine($"Journal saved to {file}");

    }

    public void LoadFromFile (string file)
    {
        if (!File.Exists(file))
        {
            Console.WriteLine("File not found");
            return;
        }
        
        _entries.Clear();
        using (StreamReader reader = new StreamReader(file))
        {
            string date, promptText, entryText;
            while (!reader.EndOfStream)
            {
                date = reader.ReadLine();
                promptText = reader.ReadLine();
                entryText = reader.ReadLine();

                _entries.Add(new Entry(date, promptText, entryText));
            } 
        }
    }

}