namespace ParkingSpace.WebApi.Controllers
{
    using Microsoft.AspNetCore.Mvc;
    using ParkingSpace.Abstractions;
    using ParkingSpace.Abstractions.Models;

    [ApiController]
    public class ParkingsController : ControllerBase
    {
        private readonly IParkingManager ParkingManager;
        public ParkingsController(IParkingManager parkingManager)
        {
            ParkingManager = parkingManager;
        }

        [HttpPost]
        [Route("api/parking")]
        public IActionResult AddParking([FromBody] Parking parking)
        {
            return Ok(ParkingManager.AddParking(parking));
        }

        [HttpPut]
        [Route("api/parking")]
        public IActionResult UpdateParking([FromBody] Parking parking)
        {
            return Ok(ParkingManager.UpdateParking(parking));
        }

        [HttpDelete]
        [Route("api/parking/{id}")]
        public IActionResult DeleteParking([FromRoute] int id)
        {
            return Ok(ParkingManager.DeleteParking(id));
        }


    }
}
