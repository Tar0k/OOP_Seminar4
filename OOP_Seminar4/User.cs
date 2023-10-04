namespace OOP_Seminar4;

public abstract class User(int id, string firstName, string middleName, string lastName)
{
    public int Id { get; } = id;
    public string FirstName { get; } = firstName;
    public string MiddleName { get; } = middleName;
    public string LastName { get; } = lastName;
    
    public int CompareTo(object? o)
    {
        if(o is User user) return Id.CompareTo(user.Id);
        throw new ArgumentException("Некорректное значение параметра");
    }
}