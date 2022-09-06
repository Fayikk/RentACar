using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class OracleDataBase : ICarDal
    {
        List<Car> _cars;
        public OracleDataBase()
        {
            _cars = new List<Car>
            {
                new Car{Brand="Mercedes",BrandId=1,ColorId=1,DailyPrice=1000,Id=1,ModelYear=2020 },
                new Car{Brand="Bmw",BrandId=2,ColorId=2,DailyPrice=1200,Id=2,ModelYear=2021 },
                new Car{Brand="Audı",BrandId=3,ColorId=3,DailyPrice=1400,Id=3,ModelYear=2022 },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            //Burada LINQ kullanılacaktır
            Car CarToDelete;
            CarToDelete = _cars.SingleOrDefault(a => a.Id == car.Id);
            _cars.Remove(CarToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int BrandId)
        {
            return _cars.Where(a => a.BrandId == BrandId).ToList();
        }

        public void Update(Car car)
        {
            Car CarToUpdate;
            CarToUpdate=_cars.SingleOrDefault(a => a.Id == car.Id);
            CarToUpdate.DailyPrice = car.DailyPrice;
            CarToUpdate.Brand = car.Brand;
            CarToUpdate.BrandId = car.BrandId;
            CarToUpdate.ColorId = car.ColorId;
            CarToUpdate.Brand = car.Brand;



        }
    }
}
