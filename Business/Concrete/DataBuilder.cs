using Business.Abstract;
using DataAccess.Abstract.ReadAndWrite;
using DataAccess.Concrete.Reader;
using DataAccess.Constants;
using System.Xml.Linq;

namespace Business.Concrete;

public class DataBuilder
{
    private readonly Generator _generator;
  
    public DataBuilder()
    {
        _generator = new Generator();
    }


    public long Id()
    {
      return  _generator.GenerateId();
       
    }

    public string MaleName()
    {
     return  _generator.GenerateMaleName();
     
    }

    public Generator Build()
    {
        _generator.GenerateId();
         _generator.GenerateMaleName();
        return _generator;
    }
}
