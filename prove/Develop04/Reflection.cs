class Reflection : Activity {
    private List<string> _prompts;
    private string _userreply;

    public Reflection(int time) : base(time) {

    }

    public void GetReply(string reply) {
        _userreply = reply;
    }
}