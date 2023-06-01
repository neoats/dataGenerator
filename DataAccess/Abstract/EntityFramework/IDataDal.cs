using Core.DataAccess;
using DataAccess.Concrete.EntityFramework;
using Entity.Concrete;

namespace DataAccess.Abstract.EntityFramework;

public interface IDataDal :IEntityIRepository<DynamicModel>
{

}