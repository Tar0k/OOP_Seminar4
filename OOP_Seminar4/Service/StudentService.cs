using OOP_Seminar4.Data;

namespace OOP_Seminar4.Service;

public class StudentService : IUserService<Student>
{
    private readonly List<Student> _students = new();

    public List<Student> GetAll() => _students;
    
    public void Create(string firstName, string secondName, string patronymic, DateOnly dateOfBirth)
    {
        var countMaxId = _students.Select(student => student.StudentId).Prepend(0).Max();
        countMaxId++;
        var newStudent = new Student(firstName, secondName, patronymic, dateOfBirth)
        {
            StudentId = countMaxId
        };
        _students.Add(newStudent);
    }
}