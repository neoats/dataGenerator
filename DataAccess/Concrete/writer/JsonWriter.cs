using System.Collections;
using System.IO;
using Newtonsoft.Json;

public class JsonWriter : IWriter
{
    private readonly string _filePath;

    public JsonWriter(string filePath)
    {
        _filePath = filePath;
    }
    public static class FileHelper
    {
        public static void ClearFile(string filePath)
        {
            File.WriteAllText(filePath, string.Empty);
        }
    }


    public void Write<T>(IEnumerable<T> items,string filename)
    {
        string newFilePath = Path.Combine(Path.GetDirectoryName(_filePath), $"{filename}.json");
        var uniqueStrings = new HashSet<T>(items);
        var json = JsonConvert.SerializeObject(uniqueStrings, Formatting.Indented);
        using (StreamWriter writer = new StreamWriter(newFilePath))
        {
            writer.Write(json);
        }
    }

}