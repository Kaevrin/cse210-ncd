using System.Net;

class Video {
    string _title;
    string _author;
    int _length;
    List<string> _comments;

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
    }
}