using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.InMemory
{
    public class InMemoryCarDal : ICarDal
    {
        List<Car> _cars;

        public InMemoryCarDal()
        {
            _cars = new List<Car>
            {
               new Car {Id=1, BrandId=1, ColorId=1, ModelYear=2022, DailyPrice=300, Description="Fiat Egea" },
               new Car {Id=2, BrandId=2, ColorId=2, ModelYear=2021, DailyPrice=280, Description="Ford Focus"},
               new Car {Id=3, BrandId=3, ColorId=2, ModelYear=2020, DailyPrice=275, Description="Opel Astra"},
               new Car {Id=4, BrandId=4, ColorId=3, ModelYear=2020, DailyPrice=340, Description="Audi A4"},
               new Car {Id=5, BrandId=5, ColorId=3, ModelYear=2017, DailyPrice=200, Description="Renault Megane"},
               new Car {Id=6, BrandId=3, ColorId=1, ModelYear=2020, DailyPrice=245, Description="Opel Vectra"},
               new Car {Id=7, BrandId=4, ColorId=2, ModelYear=2019, DailyPrice=500, Description="Audi RS 8"},
               new Car {Id=8, BrandId=2, ColorId=4, ModelYear=2023, DailyPrice=640, Description="Ford Mustang"}
            };
        }

        public void Add(Car entity)
        {
            _cars.Add(entity);
        }

        public void Delete(Car entity)
        {
            Car carToDelete = _cars.SingleOrDefault(p => p.Id == entity.Id);
            _cars.Remove(carToDelete);
        }

        public Car Get(Expression<Func<Car, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public List<Car> GetAll(Expression<Func<Car, bool>> filter = null)
        {
            return _cars;
        }     

        public List<Car> GetById(int id)
        {
            return _cars.Where(c => c.Id == id).ToList();
        }

        public List<CarDetailDto> GetCarDetails()
        {
            throw new NotImplementedException();
        }

        public void Update(Car entity)
        {
            Car carToUpdate = _cars.SingleOrDefault(p => p.Id == entity.Id);

            carToUpdate.Id = entity.Id;
            carToUpdate.BrandId = entity.BrandId;
            carToUpdate.ColorId = entity.ColorId;
            carToUpdate.ModelYear = entity.ModelYear;
            carToUpdate.DailyPrice = entity.DailyPrice;
            carToUpdate.Description = entity.Description;
        }
    }
}
