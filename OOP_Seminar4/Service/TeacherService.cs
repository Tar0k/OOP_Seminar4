using OOP_Seminar4.Data;

namespace OOP_Seminar4.Service;

public class TeacherService : IUserService<Teacher>
{
    private readonly List<Teacher> _teachers = new();

    public List<Teacher> GetAll() => _teachers;

    public void Create(string firstName, string secondName, string patronymic, DateOnly dateOfBirth)
    {
        var countMaxId = _teachers.Select(teacher => teacher.TeacherId).Prepend(0).Max();
        countMaxId++;
        var newTeacher = new Teacher(firstName, secondName, patronymic, dateOfBirth)
        {
            TeacherId = countMaxId
        };
        _teachers.Add(newTeacher);
    }

    public Teacher? Find(string? firstName = null, string? secondName = null, string? patronymic = null)
    {
        IEnumerable<Teacher> filteredTeachers = _teachers;
        if (firstName != null) filteredTeachers = filteredTeachers.Where(t => t.FirstName == firstName);
        if (secondName != null) filteredTeachers = filteredTeachers.Where(t => t.SecondName == secondName);
        if (patronymic != null) filteredTeachers = filteredTeachers.Where(t => t.Patronymic == patronymic);

        var enumerable = filteredTeachers as Teacher[] ?? filteredTeachers.ToArray();
        switch (enumerable.Length)
        {
            case 1:
                return enumerable.First();
            case 0:
                Console.WriteLine("Учитель не найден!");
                return null;
            default:
                Console.WriteLine("Найдено больше 1-го учиеля с этими данными");
                return null;
        }
    }

    public void Edit(Teacher teacher, string? newFirstName = null, string? newSecondName = null, string? newPatronymic = null)
    {
        if (!_teachers.Contains(teacher))
        {
            Console.WriteLine("Учитель не входит список");
            return;
        }
        
        if (newFirstName != null) teacher.FirstName = newFirstName;
        if (newSecondName != null) teacher.SecondName = newSecondName;
        if (newPatronymic != null) teacher.Patronymic = newPatronymic;
    }
}