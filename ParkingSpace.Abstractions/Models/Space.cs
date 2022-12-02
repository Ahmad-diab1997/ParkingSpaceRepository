namespace ParkingSpace.Abstractions.Models
{
    using System;
    public class Space
    {
        public Guid Id {
            get;
            set; 
        }

        public string Symbol {
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
    }
}
