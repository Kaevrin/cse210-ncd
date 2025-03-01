class Listing : Activity {
    private List<string> prompts;
    private string _userreply;
    private List<string> replies;

    public Listing(int time) : base(time) {
        GetRandomPrompt();
    }

    private void GetRandomPrompt() {
        Random random = new Random();
        
    }
}