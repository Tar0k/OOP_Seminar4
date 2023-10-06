namespace OOP_Seminar4.Data;

public class Student(string firstName, string secondName, string patronymic, DateOnly dateOfBirth) : User(firstName, secondName, patronymic, dateOfBirth), IComparable<Student>
{
    public long StudentId { get; set; }

    public override string ToString()
    {
        return "Student{" +
               "studentId='" + StudentId +'\'' +
               ", firstName='" + FirstName + '\'' +
               ", secondName='" + SecondName + '\'' +
               ", patronymic='" + Patronymic + '\'' +
               ", dateOfBirth=" + DateOfBirth +
               '}';
    }
    
    public int CompareTo(Student? other)
    {
        if (other != null) return StudentId.CompareTo(other.StudentId);
        throw new InvalidOperationException();
    }
}