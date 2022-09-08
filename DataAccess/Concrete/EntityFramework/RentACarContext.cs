using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework
{
    public class RentACarContext:DbContext
    {
        //DbContext ile veri tabanı işlemleri için gerekli Db ortamının tanıtılması gerekmektedir.
        //Burası bağlamdır.Veri tabanını sisteme tanıtma işlemi burada gerçekleştirilir.
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Bu method proje hangi veritabanı ile ilişkiliyi belirteceğimiz yerdir.
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Carr;Trusted_Connection=true");//Sql server'a nasıl bağlacağını belirtmemiz yeterli olacaktır.
    

        }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Color> Colors { get; set; }
        //Veri tabanımızı sisteme bağlayıp gerekli işlemleri  ve atamaları gerçekleştirdik.

    }
}
