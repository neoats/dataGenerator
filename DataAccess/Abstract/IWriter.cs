using System.Collections;

public interface IWriter 
{

    void Write<T>(IEnumerable<T> items);
};