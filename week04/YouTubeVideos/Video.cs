using System.ComponentModel.DataAnnotations;
using System.Transactions;

class Video
{
    private string _title;
    private string _author;
    private float _length;

    private List<Comment> _comments = [];

    public Video(string title, string author, float length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }

    public void Display()
    {
        Console.WriteLine("---------------------------------------------");
        Console.WriteLine(_title);
        Console.WriteLine($"Author: {_author}");
        Console.WriteLine($"Duration: {_length}");
        Console.WriteLine($"\nComments: {GetNumberOfComments()}");

        foreach (Comment comment in _comments)
        {
            comment.Display();
        }
        Console.WriteLine("---------------------------------------------");

    }
    
}