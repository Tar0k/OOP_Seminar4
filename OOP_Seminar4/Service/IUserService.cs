namespace OOP_Seminar4.Service;

public interface IUserService<T>
{
    public List<T> GetAll();
    public void Create(string firstName, string secondName, string patronymic, DateOnly dateOfBirth);
}