public class MathAssignment : Assignment
{
    private string _TextBookSection;
    private string _problems;

    public MathAssignment(string TextBookSection, string problems, string StudentName, string topic) :base(StudentName, topic)
    {
        _TextBookSection = TextBookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"{_TextBookSection} {_problems}";
    }

}