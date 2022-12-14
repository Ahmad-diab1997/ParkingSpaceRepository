namespace ParkingSpace.Abstractions
{
    using ParkingSpace.Abstractions.Models;
    public interface ISpaceStore
    {
        public string AddSpace(Space space);
        public string UpdateSpace(Space space);
        public string DeleteSpace(int spaceId);
    }
}
