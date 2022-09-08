// See https://ausing System;

using Business.Concrete;
using DataAccess.Concrete;
using DataAccess.Concrete.InMemory;

namespace MyApp // Note: actual namespace depends on the project name.
{
    public class Program
    {
        static void Main(string[] args)
        {
            //CarManager carManager = new CarManager(new InMemoryProductDal());

            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Brand);
            //}


            //CarManager carManager = new CarManager(new OracleDataBase());
            //foreach (var car in carManager.GetAll())
            //{
            //    Console.WriteLine(car.Brand);
            //}

        }
    }
}