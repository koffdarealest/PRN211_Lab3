using AutomobileLibrary.DataAccess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomobileLibrary.Repository
{
    public class CarRepository : ICarRepository
    {
        public void DeleteCar(int carID) => CarDAO.Instance.Remove(carID);

        public IEnumerable<Car> GetCars() => CarDAO.Instance.GetCarList();

        public Car GetCarByID(int carID) => CarDAO.Instance.GetCarByID(carID);

        public void InsertCar(Car car) => CarDAO.Instance.AddNew(car);

        public void UpdateCar(Car car) => CarDAO.Instance.Update(car);
    }
}
