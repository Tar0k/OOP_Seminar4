namespace OOP_Seminar4.Data;

public class Teacher(string firstName, string secondName, string patronymic, DateOnly dateOfBirth) : User(firstName, secondName, patronymic, dateOfBirth), IComparable<Teacher>
{
    public long TeacherId { get; set; }

    public override string ToString()
    {
        return "Teacher{" +
               "teacherId='" + TeacherId +'\'' +
               ", firstName='" + FirstName + '\'' +
               ", secondName='" + SecondName + '\'' +
               ", patronymic='" + Patronymic + '\'' +
               ", dateOfBirth=" + DateOfBirth +
               '}';
    }
    
    public int CompareTo(Teacher? other)
    {
        if (other != null) return TeacherId.CompareTo(other.TeacherId);
        throw new InvalidOperationException();
    }
}