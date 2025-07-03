class Comment
{
    private string _username;
    private string _text;

    public Comment(string username, string text)
    {
        _username = username;
        _text = text;
    }

    public void Display()
    {
        Console.WriteLine($"{_text} - {_username}");
        //Console.WriteLine(_text);
    }
}