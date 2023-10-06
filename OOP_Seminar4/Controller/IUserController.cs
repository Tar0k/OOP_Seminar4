using OOP_Seminar4.Data;

namespace OOP_Seminar4.Controller;

public interface IUserController<T> where T : User
{ 
    void Create(string firstName, string secondName, string patronymic, DateOnly dateOfBirth);
}