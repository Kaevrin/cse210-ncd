class Staff {
    protected string _firstName;
    protected string _lastName;
     protected string _gender;

     protected string _sentencestart;

    public Staff(string firstname, string lastname, string gender) {
        _firstName = firstname;
        _lastName = lastname;
        _gender = gender;
        if (_gender == "M") {
            _sentencestart = "Hello students, I am Mr. " + _lastName + ".";
        }
        else if (_gender == "F") {
            _sentencestart = "Hello students, I am Ms. " + _lastName + ". ";
        }
        else {
            Console.WriteLine("Gender missing");
        }
        
    }
}