class Journal
{
    public string Content {get; set; }
    public string Prompt {get; set; }
    public DateTime DateWritten {get; set; }

    public Journal(string content, string prompt)
    {
        Content = content;
        Prompt = prompt;
        DateWritten = DateTime.Now; 
    }
    public override string ToString()
    {
        return $"{DateWritten.ToString("dd/MM/yy")}:\nPrompt: {Prompt}\nResponse: {Content}\n";
    }
    public static void Save(List<Journal> journal)
    {
        using (StreamWriter writer = new StreamWriter("Journal.csv", false))
        {
            foreach (var entry in journal)
            {
               string formattedEntry = $"{entry.DateWritten:dd/MM/yy} | {entry.Prompt.Replace("|", " ")} | {entry.Content.Replace("|", " ")}";
               writer.WriteLine(formattedEntry);
           }
        
        }
    }
    public static List<Journal> Load()
    {
        List<Journal> journalLoaded = new List<Journal>();
        if (File.Exists("Journal.csv"))
        {
            using (StreamReader reader = new StreamReader("Journal.csv"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    string[] parts = line.Split(new string[] { " | "}, StringSplitOptions.None);
                    if (parts.Length == 3)
                    {
                        DateTime dateWritten = DateTime.ParseExact(parts[0], "dd/MM/yy", null);
                        string prompt = parts[1];
                        string content = parts[2];
                        journalLoaded.Add(new Journal(content, prompt) {DateWritten = dateWritten});
                    }
                }
            }
        }
        return journalLoaded;
    }
}

