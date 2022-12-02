namespace ParkingSpace.Abstractions.Store
{
    using System;
    using ParkingSpace.Abstractions.Models;
    public interface IUserStore
    {
        public string AddUser(User user);

        public string UpdateUser(User user);

        public string DeleteUser(Guid Id);
    }
}
