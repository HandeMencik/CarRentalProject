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
    public class LocationManager : ILocationService
    {
        ILocationDal _locationDal;

        public LocationManager(ILocationDal locationDal)
        {
            _locationDal = locationDal;
        }

        public IResult Add(Location location)
        {
          _locationDal.Add(location);
            return new SuccessResult();
        }

        public IResult Delete(Location location)
        {
          _locationDal.Delete(location);
            return new SuccessResult();
        }

        public IDataResult<List<Location>> GetAll()
        {
            return new SuccessDataResult<List<Location>>(_locationDal.GetAll());
        }

        public IDataResult<Location> GetById(int id)
        {
          return new SuccessDataResult<Location>(_locationDal.Get(x=>x.LocationId==id));
        }

        public IResult Update(Location location)
        {
            _locationDal.Update(location);
            return new SuccessResult();
        }
    }
}
