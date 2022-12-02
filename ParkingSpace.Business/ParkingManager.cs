namespace ParkingSpace.Business
{
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;
    using System.Collections.Generic;

    public class ParkingManager : IParkingManager
    {
        private readonly IParkingManager parkingManager;
        public ParkingManager(IParkingManager parkingManager)
        {
            this.parkingManager = parkingManager;
        }

        public string AddParking(Parking parking)
        {
            if (parking == null)
            {
                throw new System.ArgumentNullException("parking cannot be null");
            }

            return parkingManager.AddParking(parking);
        }

        public string UpdateParking(Parking parking)
        {
            if (parking == null)
            {
                throw new System.ArgumentNullException("parking cannot be null");
            }
            return parkingManager.UpdateParking(parking);
        }

        public string DeleteParking(int parkingId)
        {
            if (parkingId == 0)
            {
                throw new System.ArgumentNullException("parking cannot be null");
            }
           
           // if (carManager.GetCarsParkById(parkingId).Count > 0)
           // {
            //    throw new System.ArgumentException("Can not Delete Parking Has Cars");
            //}
            return parkingManager.DeleteParking(parkingId);
        }
    }
}
