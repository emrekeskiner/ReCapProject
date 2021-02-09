using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccess.Abstract;
using Entities.Concrete;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        private List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
                new Car{Id = 1, BrandId = 1,ColorId = 2,ModelYear = "2020",DailyPrice = 500, Description = "Otomatik"},
                new Car{Id = 2, BrandId = 1,ColorId = 5,ModelYear = "2019",DailyPrice = 250, Description = "Otomatik"},
                new Car{Id = 3, BrandId = 2,ColorId = 3,ModelYear = "2018",DailyPrice = 1000, Description = "Otomatik"},
                new Car{Id = 4, BrandId = 4,ColorId = 6,ModelYear = "2019",DailyPrice = 750, Description = "Otomatik"},
                new Car{Id = 5, BrandId = 3,ColorId = 8,ModelYear = "2021",DailyPrice = 1000, Description = "Otomatik"},
            };
        }


        public List<Car> GetAll()
        {
            return _cars;
        }

        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(c => c.Id == car.Id);
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }

        public void Delete(Car car)
        {
            Car carDelete = _cars.SingleOrDefault(c => c.Id == car.Id);
            _cars.Remove(carDelete);
        }

        public List<Car> GetById(int CarId)
        {
            return _cars.Where(c => c.Id == CarId).ToList();
        }
    }
}
