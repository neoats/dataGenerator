using System.Diagnostics;
using Business.Concrete;
using Core.Utilities;
using DataAccess.Constants;

namespace ConsoleUI;

class Program
{
    static void Main(string[] args)
    {
        /*IDataDal _datadal = new EfDataDal();

        var builder = new DataBuilder();*/
        var generator = new Generator();
        IWriter writer = new JsonWriter(new MyPath().sortData);
        var sw = Stopwatch.StartNew();

        var z = GenerateId(generator, 10000000);

        writer.Write(z, "_10M");
        sw.Stop();
        Console.WriteLine($"Geçen süre: {sw.Elapsed.Minutes} dakika {sw.Elapsed.Seconds} saniye");


        #region withbuilder

        /*       var x = builder.Id()
              Console.WriteLine(generator.GenerateId()+" "+generator.GenerateMaleName());
              */

        #endregion
    }

    [String("tuple (string sn, long id)")]
    static IEnumerable<(string sn, long id)> GenerateSnId(Generator generator, int count)
    {
        IEnumerable<(string sn, long id)> list = new List<(string, long)>();

        for (var i = 0; i < count; i++)
        {
            var sn = i.ToString();
            var id = generator.GenerateId();
            list = list.Append((sn, id));
        }

        return list;
    }

    [String("long (id)")]
    static IEnumerable<long> GenerateId(Generator generator, int count)
    {
        IEnumerable<long> z = new List<long>();

        for (var i = 0; i < count; i++)
        {
            var x = generator.GenerateId();
            z = z.Append(x);
        }

        return z;
    }


    #region oldmethod

    /*
    static List<string> Id(int count)
    {
        IGenerator generator = new Generator();

        var myList = new List<string>();
        for (var i = 0; i < count; i++)
        {
            var x = generator.Generate<string>();
            myList.Add(x[0]);
        }

        return myList;
    }*/

    #endregion

    #region oldmain

    /*IEditor editor = new Editor();
IWriter writer = new JsonWriter(new MyPath().constants);


ICsvReader cities = new CsvReader(new MyPath().citiescsv);
IReader femnames = new JsonReader(new MyPath().femnames);
IReader surnames = new JsonReader(new MyPath().surnames);
IReader jobnames = new JsonReader(new MyPath().jobnames);



List<string> firstColumnValues = new List<string>();
bool firstLine = true, secondLine = true;
var x = cities.Read<string>();
var y = femnames.Read<string>();
var z = surnames.Read<string>();
var a = jobnames.Read<string>();



foreach (var firstcol in x)
{
   if (firstLine)
   {
       firstLine = false;
       continue;
   }
   firstColumnValues.Add(firstcol[0]);

}*/

    #endregion
}