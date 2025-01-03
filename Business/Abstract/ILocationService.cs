using Core.Utulities.Results;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ILocationService
    {
        IResult Add(Location location);
        IResult Delete(Location location);
        IResult Update(Location location);
        IDataResult<List<Location>> GetAll();
        IDataResult<Location> GetById(int id);
    }
}
