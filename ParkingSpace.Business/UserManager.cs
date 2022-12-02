namespace ParkingSpace.Business
{
    using System;
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;

    internal class UserManager : IUserManager
    {
        public IUserManager userManager
        {
            get;
        }

        public UserManager(IUserManager userManager)
        {
            this.userManager = userManager;
        }

        public string AddUser(User user)
        {
            return userManager.AddUser(user);
        }

        public string UpdateUser(User user)
        {
            return userManager.UpdateUser(user);
        }

        public string DeleteUser(Guid Id)
        {
            return userManager.DeleteUser(Id);
        }
    }
}
