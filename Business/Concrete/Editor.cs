using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;

namespace Business.Concrete
{
    public class Editor:IEditor
    {
        public IEnumerable<string> RemoveDuplicates(IEnumerable<string> input)
        {
            HashSet<string> uniqueStrings = new HashSet<string>();
            List<string> outputList = new List<string>();

            foreach (string str in input)
            {
                if (!uniqueStrings.Contains(str))
                {
                    uniqueStrings.Add(str);
                    outputList.Add(str);
                }
            }

            if (outputList.Count == 0)
            {
                outputList.Add("fail");
            }

            return outputList;
        }

    }
}
