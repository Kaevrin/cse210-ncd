class Specialist : Staff {
    private string _specialty;

    public Specialist(string firstname, string lastname, string gender, string speciality) : base(firstname, lastname, gender) {
        _specialty = speciality;
        Console.WriteLine(_sentencestart + "I am a " + _specialty + " specialist.");

    }
}