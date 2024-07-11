namespace CodeWars;

public class Student : Person
{
    public Student(string firstName, string nationalCode, string userName, string password) : base(firstName, nationalCode, userName, password)
    {

    }

    public int EducationalId { get; set; }
}