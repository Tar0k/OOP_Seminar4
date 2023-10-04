namespace OOP_Seminar4;

public class Student(int id, string firstName, string middleName, string lastName, int studentNumber, DateOnly birthDate) : User(id, firstName, middleName, lastName)
{
    public int StudentNumber { get;} = studentNumber;
    public DateOnly BirthDate { get; init; } = birthDate;

    public override string ToString()
    {
        return $"{Id}: {FirstName} {MiddleName} {LastName}";
    }
}