namespace OOP_Seminar4;

public class StudentController(List<Group> groups) : IUserController
{
    private List<Group> _groups = groups;
    private readonly LearningGroupService _learningGroupService = new LearningGroupService(groups);
    
    public void RemoveStudent(int id)
    {
        _learningGroupService.RemoveById(id);
    }

    public void Sort()
    {
        foreach (var group in groups)
        {
            group.Sort();
        }
    }

    public T Create<T>(int id) where T : User, new()
    {
        return new T()
        {
            Id = id,
            FirstName = Faker.Name.First(),
            MiddleName = Faker.Name.Middle(),
            LastName = Faker.Name.Last()
        };
    }
}