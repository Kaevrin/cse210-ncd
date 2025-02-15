using System.ComponentModel.DataAnnotations;
using System.Runtime.InteropServices;

public class Scripture {
    private string _reference;

    private List<Word> _scripture = new List<Word> {};
    public Scripture(Reference reference, string text) {
        List<string> _words = new List<string>(text.Split(' '));
        _reference = reference.GetDisplayContent();
        foreach (string word in _words) {
            Word addword = new Word(word);
            _scripture.Add(addword);
        }
    }
    public Scripture(string book, int chapter, int startVerse, int endVerse) {

    }

    public void HideWords(int number) {
        Random random = new Random();
        HashSet<int> selectedIndexes = new HashSet<int>();
        List<int> visibleIndexes = new List<int>();
        for (int i = 0; i < _scripture.Count; i++) {
            if (!_scripture[i].IsHidden()) {
                visibleIndexes.Add(i);
            }
        }
        number = Math.Min(number, visibleIndexes.Count);

        while (selectedIndexes.Count < number) {
            int index = random.Next(visibleIndexes.Count);
            selectedIndexes.Add(visibleIndexes[index]);
        }
        foreach (int index in selectedIndexes) {
            _scripture[index].Hide();
        }
    }
    public bool AllHidden() {
        foreach (Word word in _scripture) {
            if (!word.IsHidden()) {
                return false;
            }
        }   
        return true;
    }
    public void ShowAll() {
        foreach (Word word in _scripture) {
            word.Show();
        }
    }
    public string GetDisplayContent() {
        string _displayContent = _reference + " - " + string.Join(" ", _scripture.Select(word => word.GetDisplayContent()));
        return _displayContent;
    }
}