using OOP_Seminar4.Data;
using OOP_Seminar4.Service;
using OOP_Seminar4.View;

namespace OOP_Seminar4.Controller;

public class TeacherController : IUserController<Teacher>
{
    private readonly TeacherService _dataService = new();
    private readonly TeacherView _teacherView = new();

    public void Create(string firstName, string secondName, string patronymic, DateOnly dateOfBirth)
    {
        _dataService.Create(firstName, secondName, patronymic, dateOfBirth);
    }

    public void Print()
    { 
        _teacherView.sendOnConsole(_dataService.GetAll());
    }

    public Teacher? Find(string? firstName = null, string? secondName = null, string? patronymic = null)
    {
        return _dataService.Find(firstName, secondName, patronymic);
    }

    public void Edit(Teacher teacher, string? newFirstName = null, string? newSecondName = null,
        string? newPatronymic = null)
    {
        _dataService.Edit(teacher, newFirstName, newSecondName, newPatronymic);
    }
}