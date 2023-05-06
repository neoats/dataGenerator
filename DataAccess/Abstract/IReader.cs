using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IReader
    {
    /*    IEnumerable<string> Read();*/
    IEnumerable<T> Read<T>();
    }
}
