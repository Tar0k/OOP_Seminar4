namespace OOP_Seminar4;

public interface IUserView<T> where T : User
{
    public void sendOnConsole(List<Student> students);
}