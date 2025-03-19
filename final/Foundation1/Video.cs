using System.Net;

class Video {
    string _title;
    string _author;
    int _length;
    List<Comment> _comments;

    public Video(string title, string author, int length) {
        _title = title;
        _author = author;
        _length = length;
        _comments = new List<Comment>();
    }
        public void AddComment(string author, string content) {
        Comment comment = new Comment(author, content);
        _comments.Add(comment);
    }
    public void Display() {
        Console.WriteLine($"{_title} ({_length} seconds) - {_author}");
        Console.WriteLine("Comments:");
        foreach (var comment in _comments) {
            comment.Display();
        }
    }
}