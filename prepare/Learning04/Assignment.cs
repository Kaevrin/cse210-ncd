public class Assignment {
    protected string _studentName;
    private string _topic;

    private string GetStudent() {
        return _studentName;
    }
    private void SetStudent(string studentname) {
        _studentName = studentname;
    }

    private string GetTopic() {
        return _studentName;
    }
    private void SetTopic(string topic) {
        _topic = topic;
    }

    public string GetSummary() {
        string summary = _studentName + " - " + _topic;
        return summary;
    }

    public Assignment(string studentname, string topic) {
        SetStudent(studentname);
        SetTopic(topic);
    }
}