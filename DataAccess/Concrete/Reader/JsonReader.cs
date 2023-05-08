using DataAccess.Abstract;
using Newtonsoft.Json;
using System.Globalization;

namespace DataAccess.Concrete.Reader
{
    public class JsonReader : IReader
    {
        private readonly string _filePath;
        private static readonly object _fileLock = new object();

        public JsonReader(string filePath)
        {
            _filePath = filePath;
        }

 
        public IEnumerable<T> Read<T>()
        {
            lock (_fileLock)
            {
                using (StreamReader reader = new StreamReader(_filePath))
                {
                    string json = reader.ReadToEnd();
                    List<T> entries = JsonConvert.DeserializeObject<List<T>>(json);
                    foreach (T entry in entries)
                    {
                        yield return entry;
                    }
                }
            }
        }





    }
}