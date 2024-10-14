public class WritingAssignment : Assignment
{
    private string _title;

    public WritingAssignment(string StudentName, string title, string topic) :base(StudentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}