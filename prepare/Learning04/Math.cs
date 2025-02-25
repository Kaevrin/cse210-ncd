class Math : Assignment {
    string _textbookSection;
    string _problems;

    public Math(string studentname, string topic, string textbooksection, string problems)
    : base(studentname, topic) {
        _textbookSection = textbooksection;
        _problems = problems;
    }
    public string GetTextbookSection() {
        return _textbookSection;
    }
    public void SetTextbookSection(string textbooksection) {
        _textbookSection = textbooksection;
    }

    public string GetProblems() {
        return _problems;
    }
    public void SetProblems(string problems) {
        _problems = problems;
    }

    public void GetHomeworkList() {
        Console.WriteLine(GetSummary());
        string homeworklist = _textbookSection + " " + _problems;
        Console.WriteLine(homeworklist);

    }


}