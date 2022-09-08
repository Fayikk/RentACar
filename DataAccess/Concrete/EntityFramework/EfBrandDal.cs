using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfBrandDal : IBrandDal
    {
        public void Add(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State=Microsoft.EntityFrameworkCore.EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var deletedEntity = context.Entry(entity);
                deletedEntity.State=Microsoft.EntityFrameworkCore.EntityState.Deleted;  
                context.SaveChanges();
            }
        }

        public Brand Get(Expression<Func<Brand, bool>> Filter)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Brand>().SingleOrDefault(Filter);
            }
        }

        public List<Brand> GetAll(Expression<Func<Brand, bool>> Filter = null)
        {
            using (RentACarContext context = new RentACarContext())
            {
                return Filter==null ? context.Set<Brand>().ToList():
                    context.Set<Brand>().Where(Filter).ToList();

            }
        }

        public void Update(Brand entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State=EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}
