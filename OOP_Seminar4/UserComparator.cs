namespace OOP_Seminar4;

public class UserComparator<T> : IComparer<T> where T : User
{
    public int Compare(T? user1, T? user2)
    {
        if(user1 is null || user2 is null) 
            throw new ArgumentException("Некорректное значение параметра");
        if (user1.Id > user2.Id) return 1;
        if (user1.Id < user2.Id) return -1;
        return 0;
    }
}