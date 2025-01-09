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
    public class ServiceManager : IServiceService
    {
        IServiceDal _serviceDal;

        public ServiceManager(IServiceDal serviceDal)
        {
            _serviceDal = serviceDal;
        }

        public IResult Add(Service service)
        {
           _serviceDal.Add(service);
            return new SuccessResult();
        }

        public IResult Delete(Service service)
        {
            _serviceDal.Delete(service);
            return new SuccessResult();
        }

        public IDataResult<List<Service>> GetAll()
        {
           return new SuccessDataResult<List<Service>>(_serviceDal.GetAll());
        }

        public IDataResult<Service> GetById(int id)
        {
            return new SuccessDataResult<Service>(_serviceDal.Get(x=>x.ServiceId==id));
        }

        public IResult Update(Service service)
        {
            _serviceDal.Update(service);
            return new SuccessResult();
        }
    }
}
