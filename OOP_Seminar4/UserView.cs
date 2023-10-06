namespace OOP_Seminar4;

public class UserView<T> : IUserView<T> where T : User
{
    public void sendOnConsole(List<Student> students)
    {
        foreach (var student in students)          
        {
            Console.WriteLine($"Id: {student.Id}\n" +
                              $"FirstName: {student.FirstName}\n" +
                              $"MiddleName: {student.MiddleName}\n" +
                              $"LastName: {student.LastName}");          
        }
    }
}