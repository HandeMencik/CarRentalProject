using Core.Utulities.Results;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IHowItWorkService
    {
        IResult Add(HowItWork howItWork);
        IResult Delete(HowItWork howItWork);
        IResult Update(HowItWork howItWork);
        IDataResult<List<HowItWork>> GetAll();
        IDataResult<HowItWork> GetById(int id);
    }
}
