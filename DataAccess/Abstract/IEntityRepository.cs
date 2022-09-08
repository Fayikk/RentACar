using Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Abstract
{   //Referans tip'tir.
    public interface IEntityRepository<T> where T :class,new()
    {
        List<T> GetAll(Expression<Func<T,bool>> Filter=null);//Delegasyon yöntemidir.
        void Add(T entity);
        void Update(T entity);
        void Delete(T entity);
        T Get(Expression<Func<T, bool>> Filter);
       
    }
}
