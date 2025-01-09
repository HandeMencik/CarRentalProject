using Core.Utulities.Results;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IPriceService
    {
        IResult Add(Price price);
        IResult Delete(Price price);
        IResult Update(Price price);
        IDataResult<List<Price>> GetAll();
        IDataResult<Price> GetById(int id);
        IDataResult<List<Price>> GetPricesWithCars();
    }
}
