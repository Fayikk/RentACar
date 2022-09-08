using DataAccess.Abstract;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfColorDal : IColorDal
    {
        Color _Color;
        public void Add(Color entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                //Referans tutucu
                var addedEntity = context.Entry(entity);
                //Eklenecek eleman olduğunu bildirmemiz gerekmektedir.
                addedEntity.State=Microsoft.EntityFrameworkCore.EntityState.Added;
                //Değişiklikleri kaydet
                context.SaveChanges();
            }
        }

        public void Delete(Color entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                //Referans tut
                var deletedEntity = context.Entry(entity);
                //Sİlinecek eleman olduğunu  belirle
                deletedEntity.State = EntityState.Deleted;
                //Değişiklikleri kaydet
                context.SaveChanges();
            }
        }

        public Color Get(Expression<Func<Color, bool>> Filter)
        {
            //Ternary operasyon
            using (RentACarContext context = new RentACarContext())
            {
                return context.Set<Color>().SingleOrDefault(Filter);
            }
           
        }

        public List<Color> GetAll(Expression<Func<Color, bool>> Filter = null )
        {
            using (RentACarContext context = new RentACarContext())
            {
                return Filter==null ? context.Set<Color>().ToList() ://Bizim eğer filtre null ise döndüreceğimiz değerdir.
                        context.Set<Color>().Where(Filter).ToList();
            }
        }

        public void Update(Color entity)
        {
            using (RentACarContext context = new RentACarContext())
            {
                var updatedEntity = context.Entry(entity);
                updatedEntity.State = EntityState.Modified; 
                context.SaveChanges();
            }
        }
    }
}
