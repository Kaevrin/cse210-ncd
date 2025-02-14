using System.ComponentModel.DataAnnotations;

public class Scripture {
    private string _reference;
    private List<string> _words = new List<string> {"Nevertheless", "the", "Lord", "seeth", "fit", "to", "chasten", "his", "people",
    "yea,", "he", "trieth", "their", "patience", "and", "their", "faith"};
    private List<Word> _scripture = new List<Word> {};
    public Scripture(string book, int chapter, int startVerse) {
        foreach (string word in _words) {
            Word addword = new Word(word);
            _scripture.Add(addword);
        }

        foreach (Word listword in _scripture) {
            string display = listword.GetDisplayContent();
            Console.Write(display);
        }
        
    }
    public Scripture(string book, int chapter, int startVerse, int endVerse) {

    }

    public void HideWords(int number) {
        
    }
    public bool AllHidden() {
     /*PLACEHOLDER*/
     return true;   
    }
}