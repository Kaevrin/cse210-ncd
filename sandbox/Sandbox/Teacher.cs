class Teacher : Staff {
    private int _roomNumber;

    public Teacher(string firstname, string lastname, string gender, int roomnumber) : base(firstname, lastname, gender) {
        _roomNumber = roomnumber;

        Console.WriteLine(_sentencestart + "I teach in room " + _roomNumber + ".");
    }
}