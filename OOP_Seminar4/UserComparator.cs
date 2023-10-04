namespace OOP_Seminar4;

public class StudentComparator: IComparer<User>
{
    public int Compare(User? user1, User? user2)
    {
        if(user1 is null || user2 is null) 
            throw new ArgumentException("Некорректное значение параметра");

        if (user1.StudentNumber > user2.StudentNumber) return 1;
        if (user1.StudentNumber < user2.StudentNumber) return -1;
        return 0;
    }
}