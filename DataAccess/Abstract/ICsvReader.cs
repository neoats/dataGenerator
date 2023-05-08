namespace DataAccess.Abstract;

public interface ICsvReader
{

    IEnumerable<T[]> Read<T>();
}