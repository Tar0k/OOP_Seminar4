using OOP_Seminar4.Data;

namespace OOP_Seminar4.View;

public class StudentView : IUserView<Student>
{
    public void sendOnConsole(List<Student> students) => students.ForEach(s => Console.WriteLine(s.ToString()));

    public void sendOnConsoleUserGroup(StudentGroup studentGroup) => Console.WriteLine(studentGroup.ToString());
}