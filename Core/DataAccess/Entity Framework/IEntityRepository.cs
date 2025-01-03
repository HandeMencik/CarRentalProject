using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Core.DataAccess.Entity_Framework
{
    public interface IEntityRepository<T> where T : class,IEntity,new()
    {
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get (Expression<Func<T, bool>> filter); //Get ve GetAll Generic yap daha sonra
        List<T> GetAll(Expression<Func<T, bool>> filter=null);

    }
}
