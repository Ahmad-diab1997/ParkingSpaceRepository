namespace ParkingSpace.Business
{
    using System;
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;

    public class CarManager : ICarManager
    {
        public ICarManager carManager
        {
            get;
        }

        public CarManager(ICarManager carManager)
        {
            this.carManager= carManager;
        }

        public string AddCar(Car car)
        {
            return carManager.AddCar(car);
        }

        public string UpdateCar(Car car)
        {
            return carManager.UpdateCar(car);
        }

        public string DeleteCar(Guid Id)
        {
            return carManager.DeleteCar(Id);
        }
    }
}
