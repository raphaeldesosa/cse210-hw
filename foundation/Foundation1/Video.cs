using System.Transactions;

public class Video
{
    public string _title;
    public string _author;
    public int _lengthInSeconds;
    public List<Comments> _comments;

    public Video(string title, string author, int lengthInSeconds)
    {
        _title = title;
        _author = author;
        _lengthInSeconds = lengthInSeconds;
        _comments = new List<Comments>();
    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLengthInSeconds()
    {
        return _lengthInSeconds;
    }


    public void addComment(Comments comments)
    {
        _comments.Add(comments);
    }

    public int GetnumberofComments()
    {
        return _comments.Count;
    }

    public List<Comments> GetComments()
    {
        return new List<Comments>(_comments);
    }


}