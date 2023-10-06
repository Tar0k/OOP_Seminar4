namespace OOP_Seminar4;

public interface IUserController
{
    public T Create<T>(int id) where T : User, new();
}