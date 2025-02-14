using System.Runtime.CompilerServices;

public class Word {
    private string _text;
    private bool _ishidden;
    
    public Word(string word) {
        _text = word;
        _ishidden = false;
    }

    private void Hide() {
        _ishidden = true;
    }

    public bool IsHidden() {
        if (_ishidden == true) {
            return true;
        }
        else {
            return false;
        }
    }
    public string GetDisplayContent() {
        string output = _ishidden ? new string('_', _text.Length) : _text;
        return output;
    }
}