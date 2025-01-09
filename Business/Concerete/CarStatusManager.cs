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
    public class CarStatusManager:ICarStatusService
    {
        ICarStatusDal _carStatusDal;

        public CarStatusManager(ICarStatusDal carStatusDal)
        {
            _carStatusDal = carStatusDal;
        }

        public IResult Add(CarStatus carStatus)
        {
           _carStatusDal.Add(carStatus);
            return new SuccessResult();
        }

        public IResult Delete(CarStatus carStatus)
        {
           _carStatusDal.Delete(carStatus);
            return new SuccessResult();
        }

        public IDataResult<List<CarStatus>> GetAll()
        {
           return new SuccessDataResult<List<CarStatus>>(_carStatusDal.GetAll());
        }

        public IDataResult<CarStatus> GetById(int id)
        {
           return new SuccessDataResult<CarStatus>(_carStatusDal.Get(x=>x.CarStatusId== id));
        }

        public IResult Update(CarStatus carStatus)
        {
            _carStatusDal.Update(carStatus);
            return new SuccessResult();
        }
    }
}
