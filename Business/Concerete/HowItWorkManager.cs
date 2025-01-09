using Business.Abstract;
using Core.Utulities.Results;
using DataAccess.Abstract;
using Entity.Concerete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.Xml;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concerete
{
    public class HowItWorkManager : IHowItWorkService
    {
        IHowItWorkDal _howItWorkDal;

        public HowItWorkManager(IHowItWorkDal howItWorkDal)
        {
          _howItWorkDal = howItWorkDal;
        }

        public IResult Add(HowItWork howItWork)
        {
          _howItWorkDal.Add(howItWork);
            return new SuccessResult();
        }

        public IResult Delete(HowItWork howItWork)
        {
            _howItWorkDal.Delete(howItWork);
            return new SuccessResult();
        }

        public IDataResult<List<HowItWork>> GetAll()
        {
           return new SuccessDataResult<List<HowItWork>>(_howItWorkDal.GetAll());
        }

        public IDataResult<HowItWork> GetById(int id)
        {
            return new SuccessDataResult<HowItWork>(_howItWorkDal.Get(x=>x.HowItWorkId == id));
        }

        public IResult Update(HowItWork howItWork)
        {
            _howItWorkDal.Update(howItWork);
            return new SuccessResult();
        }
    }
}
