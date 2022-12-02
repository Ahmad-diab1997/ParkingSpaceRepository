namespace ParkingSpace.Business
{
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;

    public class SpaceManager : ISpaceManager
    {
        public ISpaceManager spaceManager {
            get;
        }

        public SpaceManager(ISpaceManager spaceManager)
        {
            this.spaceManager = spaceManager;
        }

        public string AddSpace(Space space)
        {
            if (space == null)
            {
                throw new System.ArgumentNullException("space cannot be null");
            }
            return spaceManager.AddSpace(space);
        }

        public string UpdateSpace(Space space)
        {
            if (space == null)
            {
                throw new System.ArgumentNullException("space cannot be null");
            }
            return spaceManager.UpdateSpace(space);
        }

        public string DeleteSpace(int spaceId)
        {
            if (spaceId == 0)
            {
                throw new System.ArgumentException("spaceId cannot be null");
            }

            //if (carManager.GetCarsParkById(spaceId).Count > 0)
            // {
            //    throw new System.ArgumentException("Can not Delete Space Has Cars");
            // }

            return spaceManager.DeleteSpace(spaceId);
        }
    }
}
