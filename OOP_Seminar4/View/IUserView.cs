using OOP_Seminar4.Data;

namespace OOP_Seminar4.View;

public interface IUserView<T> where T : User
{
    
void sendOnConsole(List<T> list);

}