using OOP_Seminar4.Data;
using OOP_Seminar4.Service;
using OOP_Seminar4.View;

namespace OOP_Seminar4.Controller;

public class StudentController : IUserController<Student>
{

    private readonly StudentService _dataService = new();
    private readonly StudentGroupService _studentGroupService;
    private readonly StudentView _studentView = new();


    public StudentController(Teacher teacher, List<Student> students)
    {
        _studentGroupService = new StudentGroupService(teacher, students);
        _studentView.sendOnConsoleUserGroup(_studentGroupService.StudentGroup);
    }
    
    public void Create(string firstName, string secondName, string patronymic, DateOnly dateOfBirth) {
        _dataService.Create(firstName, secondName, patronymic, dateOfBirth);
        _studentView.sendOnConsole(_dataService.GetAll());
    }

    public void GetStudentInStudentGroup(string firstName, string secondName){
        var student = _studentGroupService.GetStudentFromGroup(firstName, secondName);
        _studentView.sendOnConsole(new List<Student> { student });
    }

    public void GetSortedListStudentFromStudentGroup(){
        var students = _studentGroupService.GetSortedStudentGroup();
        _studentView.sendOnConsole(students);
    }

    public void GetSortedListByFioStudentFromStudentGroup(){
        var students = _studentGroupService.GetSortedByFioStudentGroup();
        _studentView.sendOnConsole(students);
    }
}