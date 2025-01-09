using Core.DataAccess.Entity_Framework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entity.Concerete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfCarDal : EfEntityRepositoryBase<Car, CarRentalContext>, ICarDal
    {
        public List<Car> GetAllCarsWithBrands()
        {
            var context = new CarRentalContext();
            var results = context.Cars.Include(x => x.Brand).Include(y=>y.CarStatus).Include(z=>z.Category).ToList();
            return results;
        }
    }
}
