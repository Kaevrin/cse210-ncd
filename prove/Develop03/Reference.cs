using System.Collections.Concurrent;

public class Reference {
    string _book;
    int _chapter;
    int _startVerse;
    int _endVerse;

    public Reference(string book, int chapter, int startverse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
        Scripture scripture = new Scripture(book, chapter, startverse);

    }
    public Reference(string book, int chapter, int startverse, int endVerse) {
        _book = book;
        _chapter = chapter;
        _startVerse = startverse;
        _endVerse = endVerse;
        Scripture scripture = new Scripture(book, chapter, startverse, endVerse);
        
    }
    public string GetDisplayContent() {
        return GetDisplayContent();
    }
}