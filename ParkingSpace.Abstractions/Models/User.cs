using System;

namespace ParkingSpace.Abstractions.Models
{
    public class User
    {
        public Guid Id
        {
            get;
            set;
        }

        public string FirstName
        {
            get;
            set;
        }

        public string LastName
        {
            get;
            set;
        }

        public int Money
        {
            get;
            set;
        }
    }
}
