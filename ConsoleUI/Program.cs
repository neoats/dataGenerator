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
            
           /* IReader reader = new JsonReader(new MyPath().mnames);*/
            ICsvReader reader = new CsvReader(new MyPath().uscitiescsv);
            IEditor editor = new Editor();
            /*IWriter writer = new JsonWriter(new MyPath().constants);*/

            List<string> firstColumnValues = new List<string>();
            bool firstLine = true,secondLine=true;
            var x = reader.Read<string>();


            foreach (var firstcol in x)
            {
                if (firstLine)
                {
                    firstLine = false;
                    continue;
                }
                firstColumnValues.Add(firstcol[0]);

            }

            foreach (var mycol in firstColumnValues)
            {
                Console.WriteLine(mycol);
            }








        }
}
}