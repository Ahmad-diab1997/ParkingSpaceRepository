namespace ParkingSpace.Abstractions
{
    using System;
    using ParkingSpace.Abstractions.Models;

    public interface IUserManager
    {
        public string AddUser(User user);

        public string UpdateUser(User user);

        public string DeleteUser(Guid Id);
    }
}
