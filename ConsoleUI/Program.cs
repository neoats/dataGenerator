using Business.Abstract;
using Business.Concrete;
using DataAccess.Abstract;
using DataAccess.Concrete.Reader;
using DataAccess.Constants;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            IReader reader = new JsonReader(new MyPath().newjobs);
            IEditor editor = new Editor();
            IWriter writer = new JsonWriter(new MyPath().newjobsfp);
            var x = reader.Read<string>();
        /*    var z = editor.RemoveDuplicates(x);
            try
            {
                writer.Write(z);
                Console.WriteLine("done");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }
          */
        foreach (var ex in x)
        {
            Console.WriteLine(ex);
        }






        }
    }
}