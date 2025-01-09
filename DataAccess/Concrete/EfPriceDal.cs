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
    public class EfPriceDal : EfEntityRepositoryBase<Price, CarRentalContext>, IPriceDal
    {
        public List<Price> GetPricesWithCars()
        {
         var contex= new CarRentalContext();
            var results=contex.Prices.Include(x=>x.Car).ThenInclude(y=>y.Brand).ToList();
            return results;
        }
    }
}
