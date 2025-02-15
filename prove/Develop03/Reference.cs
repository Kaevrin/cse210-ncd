using System.Collections.Concurrent;

public class Reference {
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _endVerse;

    string _reference;

    public Reference(string book, int chapter, int startverse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
        _reference = $"{_book} {_chapter}:{startverse}";
    }
    public Reference(string book, int chapter, int startverse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
        _endVerse = endVerse;
        _reference = $"{_book} {_chapter}:{startverse}-{endVerse}";
    }
    public string GetDisplayContent() {
        return _reference;
    }
}