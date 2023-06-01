using Business.Abstract;
using DataAccess.Abstract.ReadAndWrite;
using DataAccess.Constants;
using System.Linq;
using DataAccess.Concrete.Reader;
using System;

namespace Business.Concrete
{
    public class Generator :IGenerator
    {
        private readonly List<int> _generatedNumbers;
    
        public Generator()
        {
            _generatedNumbers = new List<int>();
        }

        //refactor
        public long GenerateId()
        {
            string id = "";
            id += Random.Shared.Next(1, 10);
            for (int i = 0; i < 11; i++)
            {
                id += Random.Shared.Next(0, 10);
            }

            while (_generatedNumbers.Contains((int)Convert.ToInt64(id)))
            {
                id = "";
                id += Random.Shared.Next(1, 10);
                for (int i = 0; i < 11; i++)
                {
                    id += Random.Shared.Next(0, 10);
                }
            }

            long generatedId = Convert.ToInt64(id);
            _generatedNumbers.Add((int)generatedId);
            return generatedId;
        }

        public string GenerateMaleName()
        {
            IReader jmnames = new JsonReader(new MyPath().malenames);
            var mnames = jmnames.Read<string>();

            var randomName = mnames.ElementAt(Random.Shared.Next(mnames.Count()));

            return randomName;
        }



    }
}
