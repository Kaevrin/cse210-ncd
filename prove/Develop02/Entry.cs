
public class Entry
{
    public string _entryfinal = "";
    public string _entry = "";
    public string _confirm = "";
    public void Input()
    {   
        _entry = Console.ReadLine();
        Console.WriteLine("Are you sure you want to save? Y/N");
        _confirm = Console.ReadLine();
        if (_confirm == "Y")
        {
            _entryfinal = _entry;
            _entry = "";
            _confirm = "";
            Console.WriteLine("Entry completed!");
        }
        else if (_confirm == "N")
        {
            _entry = "";
            _confirm = "";
            Console.WriteLine("Entry canceled.");
        }
        else
        {
            _confirm = "";
            Console.WriteLine("Invalid input.");
        }

    }
    public void Delete()
    {
        Console.WriteLine($"You are attempting to delete the following:\n{_entryfinal}\nAre you sure? Y/N");
                _confirm = Console.ReadLine();
        if (_confirm == "Y")
        {
            _entryfinal = _entry;
            _confirm = "";
            Console.WriteLine("Entry deleted!");
        }
        else if (_confirm == "N")
        {
            _confirm = "";
            Console.WriteLine("Entry not deleted.");
        }
        else
        {
            _confirm = "";
            Console.WriteLine("Invalid input.");
        }
    }
    public void Display()
    {
        if (_entryfinal != "")
        {
            Console.WriteLine($"{_entryfinal}");
        }
        else
        {
            Console.WriteLine("There is no entry.");
        }
    }
    public string GetEntry()
    {
        return _entryfinal;
    }
}