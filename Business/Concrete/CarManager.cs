using Business.Abstract;
using DataAccess.Abstract;
using Entities.Concrete;
using Entities.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class CarManager : ICarService
    {
        ICarDal _carService;

        public CarManager(ICarDal carService)
        {
            _carService = carService;
        }

        public List<Car> GetAll()
        {
            return _carService.GetAll();
        }

        public Car GetById(int carId)
        {
            return _carService.Get(c => c.Id == carId);
        }

        public List<CarDetailDto> GetCarDetails()
        {
            return _carService.GetCarDetails();
        }
    }
}
