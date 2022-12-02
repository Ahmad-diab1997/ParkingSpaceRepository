namespace ParkingSpace.Abstractions
{
    using ParkingSpace.Abstractions.Models;
    public interface IParkingManager
    {
        public string AddParking(Parking parking);
        public string UpdateParking(Parking parking);
        public string DeleteParking(int parkingId);
    }
}
