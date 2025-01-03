using Core.Utulities.Results;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarStatusService
    {
        IResult Add(CarStatus carStatus);
        IResult Delete(CarStatus carStatus);
        IResult Update(CarStatus carStatus);
        IDataResult<List<CarStatus>> GetAll();
        IDataResult<CarStatus> GetById(int id);
    }
}
