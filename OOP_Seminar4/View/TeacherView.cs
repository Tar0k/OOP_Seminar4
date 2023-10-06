using OOP_Seminar4.Data;

namespace OOP_Seminar4.View;

public class TeacherView
{
    public void sendOnConsole(List<Teacher> teachers) => teachers.ForEach(s => Console.WriteLine(s.ToString()));
}