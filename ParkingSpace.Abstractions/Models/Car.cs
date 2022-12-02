namespace ParkingSpace.Abstractions.Models
{
    using System;
    public class Car
    {
        public Guid Id
        {

            get;
            set;
        }

        public int Model
        {

            get;
            set;
        }

        public string Version
        {

            get;
            set;
        }

        public string Color
        {
            get;
            set;
        }

        public int Height
        {

            get;
            set;
        }

        public int Width
        {

            get;
            set;
        }

    }
}
