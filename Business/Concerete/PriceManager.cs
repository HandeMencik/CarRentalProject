using Business.Abstract;
using Core.Utulities.Results;
using DataAccess.Abstract;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerete
{
    public class PriceManager : IPriceService
    {
        IPriceDal _priceDal;

        public PriceManager(IPriceDal priceDal)
        {
            _priceDal = priceDal;
        }

        public IResult Add(Price price)
        {
            _priceDal.Add(price);
            return new SuccessResult();
        }

        public IResult Delete(Price price)
        {
           _priceDal.Delete(price);
            return new SuccessResult();
        }

        public IDataResult<List<Price>> GetAll()
        {
          return new SuccessDataResult<List<Price>>(_priceDal.GetAll());
        }

        public IDataResult<Price> GetById(int id)
        {
           return new SuccessDataResult<Price>(_priceDal.Get(x=>x.PriceId == id));
        }

        public IDataResult<List<Price>> GetPricesWithCars()
        {
            return new SuccessDataResult<List<Price>>(_priceDal.GetPricesWithCars());
        }

        public IResult Update(Price price)
        {
            _priceDal.Update(price);
            return new SuccessResult();
        }
    }
}
