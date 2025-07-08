public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string t, string p) : base(name, topic)
    {
        _textbookSection = t;
        _problems = p;
    }

    public string GetHomeworkList()
    {
        return _textbookSection + " " + _problems;
    }

}