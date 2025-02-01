class Journal
{
    public string Content {get; set; }
    public DateTime DateWritten {get; set; }

    public Journal(string content)
    {
        Content = content;
        DateWritten = DateTime.Now; 
    }
    public override string ToString()
    {
        return $"{DateWritten.ToString("dd/MM/yy")}: {Content}";
    }
    public void Save()
    {
        foreach (var line in entries)
        {
            using (StreamWriter writer = new StreamWriter("Journal.csv"))
            {
                writer.WriteLine(line.ToString());
            }
        }
    }
}   

