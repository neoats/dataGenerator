using Business.Abstract;

namespace Business.Concrete
{
    public class Generator 
    {
        private readonly Random _random;
        private readonly HashSet<string> _myIds;
        private int _count;

        public Generator()
        {
            _random = new Random();
            _myIds = new HashSet<string>();
            _count = 0;
        }

        //refactor
        public (long, int) Generate()
        {
            string id = "";
            id += _random.Next(1, 10);
            for (int i = 0; i < 11; i++)
            {
                id += _random.Next(0, 10);
            }

            while (_myIds.Contains(id))
            {
                id = "";
                id += _random.Next(1, 10);
                for (int i = 0; i < 11; i++)
                {
                    id += _random.Next(0, 10);
                }
            }

            _count++;
            _myIds.Add(id);
            return (Convert.ToInt32(id), _count);
        }

       

    }

}
