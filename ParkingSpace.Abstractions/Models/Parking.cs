namespace ParkingSpace.Abstractions.Models
{
    using System;
    public class Parking
    {
        public Guid Id {
            get;
            set; 
        }

        public string Name {
            get;
            set;
        }

        public string Symbol
        {
            get;
            set;
        }

        public ParkingTypes ParkingTypes {
            get;
            set; 
        }

        public int Width { 
            get;
            set;
        }

        public int Height
        {
            get;
            set;
        }

        public int PricePerHour
        {
            get;
            set;
        }
    }
}
