public class WritingAssignment : Assignment 
{
    private string _title;

    public WritingAssignment(string studentName, string topic, string tittle) : base(studentName, topic)
    {
        _title = tittle;
    }

    public string GetWritingInformation()
    {
        string studentName = GetStudentName();
        return $"{_title} by {studentName}";
    }
}