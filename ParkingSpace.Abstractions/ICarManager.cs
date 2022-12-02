namespace ParkingSpace.Abstractions
{
    using System;
    using ParkingSpace.Abstractions.Models;

    public interface ICarManager
    {
        public string AddCar(Car car);

        public string UpdateCar(Car car);

        public string DeleteCar(Guid Id);
    }
}
