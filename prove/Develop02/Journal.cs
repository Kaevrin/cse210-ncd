class Journal
{
    public string _content {get; set; }
    public string _prompt {get; set; }
    public DateTime _dateWritten {get; set; }

    public Journal(string content, string prompt)
    {
        _content = content;
        _prompt = prompt;
        _dateWritten = DateTime.Now; 
    }
    public override string ToString()
    {
        return $"{_dateWritten.ToString("dd/MM/yy")}:\nPrompt: {_prompt}\nResponse: {_content}\n";
    }
    public static void Save(List<Journal> _journal)
    {
        using (StreamWriter _writer = new StreamWriter("Journal.csv", false))
        {
            foreach (var entry in _journal)
            {
               string formattedEntry = $"{entry._dateWritten:dd/MM/yy} | {entry._prompt.Replace("|", " ")} | {entry._content.Replace("|", " ")}";
               _writer.WriteLine(formattedEntry);
           }
        
        }
    }
    public static List<Journal> Load()
    {
        List<Journal> _journalLoaded = new List<Journal>();
        if (File.Exists("Journal.csv"))
        {
            using (StreamReader _reader = new StreamReader("Journal.csv"))
            {
                string _line;
                while ((_line = _reader.ReadLine()) != null)
                {
                    string[] _parts = _line.Split(new string[] { " | "}, StringSplitOptions.None);
                    if (_parts.Length == 3)
                    {
                        DateTime dateWritten = DateTime.ParseExact(_parts[0], "dd/MM/yy", null);
                        string _prompt = _parts[1];
                        string _content = _parts[2];
                        _journalLoaded.Add(new Journal(_content, _prompt) {_dateWritten = dateWritten});
                    }
                }
            }
        }
        return _journalLoaded;
    }
}

