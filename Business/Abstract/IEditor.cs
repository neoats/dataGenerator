namespace Business.Abstract;

public interface IEditor
{
     IEnumerable<string> RemoveDuplicates(IEnumerable<string> input);
     IEnumerable<string> RemoveDuplicateLetter(IEnumerable<string> input);
}