public class Comments
{
    public string _CommenterName;
    public string _CommenterText;

    public Comments(string CommenterName, string CommenterText)
    {
        _CommenterName = CommenterName;
        _CommenterText = CommenterText;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"{_CommenterName}: {_CommenterText}");
    }
}