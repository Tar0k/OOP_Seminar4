using OOP_Seminar4.Data;

namespace OOP_Seminar4.Service;

public class StudentGroupService(Teacher teacher, List<Student> students)
{
    public StudentGroup StudentGroup { get; private set; } = new(teacher, students);

    public Student GetStudentFromGroup(string firstName, string secondName)
    {
        var foundStudents = StudentGroup.Where(student => student.FirstName == firstName && student.SecondName == secondName).ToArray();

        return foundStudents.Length switch
        {
            1 => foundStudents.First(),
            0 => throw new Exception($"$Студент с именем {firstName} и фамилией {secondName} не найден"),
            _ => throw new Exception("Найдено более одного студента с указанными именем и фамилией")
        };
    }
    
    public List<Student> GetSortedStudentGroup()
    {
        var students = new List<Student>(StudentGroup);
        students.Sort();
        return students;
    }
    
    public List<Student> GetSortedByFioStudentGroup(){
         var students = new List<Student>(StudentGroup);
         students.Sort(new UserComparator<Student>());
         return students;
     }
    
}