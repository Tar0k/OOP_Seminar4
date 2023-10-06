using System.Collections;

namespace OOP_Seminar4.Data;

public class StudentGroupIterator(StudentGroup studentGroup) : IEnumerator<Student>
{
    private int _counter;
    private readonly List<Student> _students = studentGroup.Students;

    public bool MoveNext()
    {
        if (_counter + 1 >= _students.Count) return false;
        _counter++;
        return true;
    }

    public void Reset() => _counter = 0;

    public Student Current => _students[_counter];

    object IEnumerator.Current => Current;

    public void Dispose() { }
}