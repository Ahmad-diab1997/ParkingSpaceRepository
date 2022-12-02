namespace ParkingSpace.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;

    [ApiController]
    public class SpacesController : ControllerBase
    {
        private readonly ISpaceManager SpaceManager;
        public SpacesController(ISpaceManager spaceManager)
        {
            SpaceManager = spaceManager;
        }

        [HttpPost]
        [Route("api/spaces")]
        public IActionResult AddSpace([FromBody] Space space)
        {
            return Ok(SpaceManager.AddSpace(space));
        }

        [HttpPut]
        [Route("api/spaces")]
        public IActionResult UpdateSpace([FromBody] Space space)
        {
            return Ok(SpaceManager.UpdateSpace(space));
        }

        [HttpDelete]
        [Route("api/spaces/{id}")]
        public IActionResult DeleteSpace([FromRoute] int id)
        {
            return Ok(SpaceManager.DeleteSpace(id));
        }
    }
}
