using Business.Concrete;
using DataAccess.Concrete.EntityFramework;
using DataAccess.Concrete.InMemory;

//CarGetAll();

CarDetails();

static void CarGetAll()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetAll())
    {
        Console.WriteLine(car.Description);
    }
}

static void CarDetails()
{
    CarManager carManager = new CarManager(new EfCarDal());

    foreach (var car in carManager.GetCarDetails())
    {
        Console.WriteLine(car.BrandName + " / " + car.CarName + " / " + car.ColorName + " / " + car.DailyPrice);

    }
}