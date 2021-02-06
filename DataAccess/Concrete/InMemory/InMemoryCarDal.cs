using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
   public  class InMemoryCarDal : ICarDal

    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{CarId=1, BrandId=1, ColorId=1, ModelYear=1990, DailyPrice=30000, Description= "ghg" },
                new Car{CarId=2, BrandId=2, ColorId=2, ModelYear=1991, DailyPrice=31000, Description= "1 km" },
                new Car{CarId=3, BrandId=3, ColorId=3, ModelYear=1992, DailyPrice=32000, Description= "40 km" },
                new Car{CarId=4, BrandId=4, ColorId=4, ModelYear=1993, DailyPrice=33000, Description= "100 km" },
            };
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int Id)
        {
            return _cars.Where(p => p.CarId == p.CarId).ToList(); 
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.CarId == car.CarId);
        }
    }
}
