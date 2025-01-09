using Core.DataAccess.Entity_Framework;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{
    public interface IHowItWorkDal:IEntityRepository<HowItWork>
    {
    }
}
