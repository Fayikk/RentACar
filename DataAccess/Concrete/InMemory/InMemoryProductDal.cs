using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryProductDal:ICarDal
    {
        //Bellekte ürün ile ilgili veri erişim kodlarının yazıldığı yerdir.
        List<Car> _cars;
        public InMemoryProductDal()
        {
            _cars = new List<Car>
            {
                new Car{Brand="Ford",ColorId=1,DailyPrice=100,Description="İts Amazing",Id=1,ModelYear=2012 },
                new Car{Brand="Opel",ColorId=2,DailyPrice=150,Description="İts Success",Id=2,ModelYear=2013},
                new Car{Brand="Wolksvagen",ColorId=3,DailyPrice=170,Description="İts wonderfull",Id=3,ModelYear=2014 },
                new Car{Brand="Seat",ColorId=4,DailyPrice=160,Description="İts crazy",Id=4,ModelYear=2015},
                new Car{Brand="Porsche",ColorId=5,DailyPrice=180,Description="İts beatifull",Id=5,ModelYear=2016},
                new Car{Brand="Audi",ColorId=6,DailyPrice=165,Description="İts speeder",Id=6,ModelYear=2017},
        };//Burada cars newleme işlemini gerçekleştirdik.


        }

        public void Add(Car car)
        {
            _cars.Add(car);//Veri tabanına ekleme işlemi olarak kabul edebiliriz.
        }

        public void Delete(Car car)
        {
            Car CarToDelete;
            CarToDelete = _cars.SingleOrDefault(c => c.Id == car.Id);//LINQ işimizi kolaylaştırıyor
            _cars.Remove(CarToDelete);//Burada silme işlemi gerçkleştiriyoruz

        }

        public List<Car> GetAll()
        {
            return _cars;//_cars'a nesnelerimizi kaydediyorduk.
        }

        //public List<Car> GetById(int BrandId)
        //{
        //    return _cars.Where(d => d.BrandId == BrandId).ToList();
        //}

        public void Update(Car car)
        {
            Car CarToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Description = car.Description;
            CarToUpdate.Id = car.Id;    
            CarToUpdate.ModelYear = car.ModelYear;
            CarToUpdate.Brand = car.Brand;
            CarToUpdate.ColorId=car.ColorId;
            

        }
    }
}
