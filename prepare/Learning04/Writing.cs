class Writing : Assignment{
    string _title;

    public Writing(string studentname, string topic, string title) 
    : base(studentname, topic) {
        _title = title;
    }
    public void GetWritingInformation() {
        Console.WriteLine(GetSummary());
        string writinginformation = _title + " by " + _studentName;
        Console.WriteLine(writinginformation);
    }
}