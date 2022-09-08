using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface ICarService
    {
        List<Car> GetAll();
        //List<Car> GetCarsByBrandId(int Id);
        List<Color> GetCarsByColorId(int min,int max);

        List<Car> Add(Car car); 
    }
}
