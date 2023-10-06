namespace OOP_Seminar4.Data;

public class UserComparator<T> : IComparer<T> where T : User
{
    public int Compare(T? x, T? y)
    {
        if (x == null || y == null)
            throw new ArgumentNullException();
        var resultOfComparing = string.Compare(x.SecondName, y.SecondName, StringComparison.Ordinal);
        if (resultOfComparing != 0) return resultOfComparing;
        
        resultOfComparing = string.Compare(x.FirstName, y.FirstName, StringComparison.Ordinal);
        if (resultOfComparing != 0) return resultOfComparing;
        
        resultOfComparing = string.Compare(x.Patronymic, y.Patronymic, StringComparison.Ordinal);
        if (resultOfComparing != 0) return resultOfComparing;

        return resultOfComparing;
    }
}