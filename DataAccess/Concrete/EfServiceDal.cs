using Core.DataAccess.Entity_Framework;
using DataAccess.Abstract;
using DataAccess.Context;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class EfServiceDal:EfEntityRepositoryBase<Service,CarRentalContext>,IServiceDal
    {
    }
}
