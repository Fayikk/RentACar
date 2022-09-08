using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _ICarDal;

        public CarManager(ICarDal CarDal)
        {
            _ICarDal = CarDal;
        }

        public List<Car> Add(Car car)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll()
        {
            return _ICarDal.GetAll();
        }

        

       

        List<Color> ICarService.GetCarsByColorId(int min, int max)
        {
            return _ICarDal.GetAll(p => p. >= min && p.ColorId <= max);
        }
    }
}
