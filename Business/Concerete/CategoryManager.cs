﻿using Business.Abstract;
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
   

    public class CategoryManager : ICategoryService
    {
        ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public IResult Add(Category category)
        {
           _categoryDal.Add(category);
            return new SuccessResult();
        }

        public IResult Delete(Category category)
        {
          _categoryDal.Delete(category);
            return new SuccessResult();
        }

        public IDataResult<List<Category>> GetAll()
        {
        return new SuccessDataResult<List<Category>>(_categoryDal.GetAll());
        }

        public IDataResult<Category> GetById(int id)
        {
           return new SuccessDataResult<Category>(_categoryDal.Get(x=>x.CategoryId==id));
        }

        public IResult Update(Category category)
        {
         _categoryDal.Update(category);
            return new SuccessResult();
        }
    }
}
