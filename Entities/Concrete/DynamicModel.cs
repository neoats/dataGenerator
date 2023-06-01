using Core.Entities.Abstract;
using System.ComponentModel.DataAnnotations.Schema;
using System.Xml;

namespace Entity.Concrete
{
    public class DynamicModel : IEntity
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
    }
  

}
