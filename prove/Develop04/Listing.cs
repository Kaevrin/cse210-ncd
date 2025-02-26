class Listing : Activity {
    List<string> prompts;
    string _userreply;
    List<string> replies;

    public Listing(int time) : base(time) {
        GetRandomPrompt();
    }

    private void GetRandomPrompt() {
        Random random = new Random();
        
    }
}