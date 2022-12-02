using System;
using ParkingSpace.Abstractions.Models;

namespace ParkingSpace.Abstractions
{
    public interface ICarStore
    {
        public string AddCar(Car car);

        public string UpdateCar(Car car);

        public string DeleteCar(Guid Id);
    }
}
