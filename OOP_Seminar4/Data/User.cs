namespace OOP_Seminar4.Data;

public class User(string firstName, string secondName, string patronymic, DateOnly dateOfBirth)
{
    public string FirstName { get; set; } = firstName;
    public string SecondName { get; set; } = secondName;
    public string Patronymic { get; set; } = patronymic;
    public DateOnly DateOfBirth { get; set; } = dateOfBirth;

    public override string ToString()
    {
        return "User{" +
               "firstName='" + firstName + '\'' +
               ", secondName='" + secondName + '\'' +
               ", patronymic='" + patronymic + '\'' +
               ", dateOfBirth=" + dateOfBirth +
               '}';
    }

    protected bool Equals(User other)
    {
        return FirstName == other.FirstName && SecondName == other.SecondName && Patronymic == other.Patronymic && DateOfBirth.Equals(other.DateOfBirth);
    }
}