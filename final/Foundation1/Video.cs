using System.Runtime.InteropServices;
using System.Transactions;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments = new();

    public Video(string title, string author, int length) 
    {
        _title = title;
        _author = author;
        _length = length;
    }

    public void AddComment(string user, string comment)
    {
        _comments.Add(new Comment(user, comment));
    }

    public void GetVideo() 
    {
        Console.WriteLine($"{_title}, {_author}, {_length}, {GetNumberOfComments()}");
        GetComments();
    }

    public void GetComments()
    {
        foreach (Comment c in _comments)
        {
            Console.WriteLine($"\n{c.GetUser()}");
            Console.WriteLine($"{c.GetComment()}");
        }
    }

    public int GetNumberOfComments()
    {
        return _comments.Count;
    }
}