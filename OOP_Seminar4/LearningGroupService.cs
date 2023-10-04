

namespace OOP_Seminar4;

public class LearningGroupService(List<Group> groups)
{
    public void RemoveById(int id)
    {
        foreach (var group in groups)
        {
            foreach (var student in group)
            {
                if (student.Id == id) group.Remove();
            }
        }
    }
}