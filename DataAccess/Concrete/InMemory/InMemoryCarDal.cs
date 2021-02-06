using DataAccess.Abstract;
using Enitity.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;
        public InMemoryCarDal()
        {
            _cars = new List<Car> {
            new Car { Id = 1, BrandId = 1, ColorId = 2, ModelYear = "2021", DailyPrice = 190000, Description = "Son model kırmızı araba" },
            new Car { Id = 2, BrandId = 1, ColorId = 1, ModelYear = "2018", DailyPrice = 120000, Description = "2018 model beyaz araba" },
            new Car { Id = 3, BrandId = 2, ColorId = 1, ModelYear = "2020", DailyPrice = 175000, Description = "2020 model beyaz araba" },
            new Car { Id = 4, BrandId = 2, ColorId = 3, ModelYear = "2020", DailyPrice = 180000, Description = "2020 model sarı araba" },
            new Car { Id = 5, BrandId = 3, ColorId = 4, ModelYear = "2019", DailyPrice = 100000, Description = "2019 model mavi araba" }
            };
        }
        public void Add(Car car)
        {
            _cars.Add(car);
        }

        public void Delete(Car car)
        {
            Car carToDelete = _cars.SingleOrDefault(p=>p.Id == car.Id);
            _cars.Remove(carToDelete);
        }

        public List<Car> GetAll()
        {
            return _cars;
        }

        public List<Car> GetById(int carId)
        {
            return _cars.Where(p=>p.Id == carId).ToList();
        }

        public void Update(Car car)
        {
            Car carToUpdate = _cars.SingleOrDefault(p=>p.Id == car.Id);
            carToUpdate.ColorId = car.ColorId;
            carToUpdate.BrandId = car.BrandId;
            carToUpdate.ModelYear = car.ModelYear;
            carToUpdate.DailyPrice = car.DailyPrice;
            carToUpdate.Description = car.Description;
        }
    }
}
