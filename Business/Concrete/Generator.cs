using Business.Abstract;

namespace Business.Concrete
{
    public class Generator 
    {
        private readonly List<int> _generatedNumbers;

        public Generator()
        {
            _generatedNumbers = new List<int>();
        }

        //refactor
       /* public List<T> Generate<T>()
        {
            string id = "";
            id += Random.Shared.Next(1, 10);
            for (int i = 0; i < 11; i++)
            {
                id += Random.Shared.Next(0, 10);
            }

            while (_generatedNumbers.Contains(id))
            {
                id = "";
                id += Random.Shared.Next(1, 10);
                for (int i = 0; i < 11; i++)
                {
                    id += Random.Shared.Next(0, 10);
                }
            }

         
          
            return (Convert.ToInt32(id));
        }
*/
       

    }

}
