using System.Collections;

namespace OOP_Seminar4.Data;

public class StudentGroup(Teacher teacher, List<Student> students) : IEnumerable<Student>
{
    public Teacher Teacher { get; set; } = teacher;
    public List<Student> Students { get; set; } = students;

    public IEnumerator<Student> GetEnumerator()
    {
        return students.GetEnumerator();
    }

    public override string ToString()
    {
        return $"StudentGroup {{students= {string.Join("\n", Students)}}}\nteacher= {Teacher}";
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return new StudentGroupIterator(this);
    }
}