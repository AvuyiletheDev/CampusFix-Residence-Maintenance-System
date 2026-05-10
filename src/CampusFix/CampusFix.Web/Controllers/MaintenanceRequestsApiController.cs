using CampusFix.Application.Services;
using CampusFix.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CampusFix.Web.Controllers
{
    [ApiController]
    [Route("api/requests")]
    public class MaintenanceRequestsApiController : ControllerBase
    {
        private readonly MaintenanceRequestService _requestService;

        public MaintenanceRequestsApiController(
            MaintenanceRequestService requestService)
        {
            _requestService = requestService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_requestService.GetAllRequests());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var request = _requestService.GetRequestById(id);

            if (request == null)
            {
                return NotFound($"Request with ID '{id}' was not found.");
            }

            return Ok(request);
        }

        [HttpPost]
        public IActionResult Create([FromBody] MaintenanceRequest request)
        {
            _requestService.SaveRequest(request);

            return CreatedAtAction(nameof(GetById),
                new { id = request.Id },
                request);
        }

        [HttpPost("{requestId}/assign/{technicianId}")]
        public IActionResult AssignTechnician(
            string requestId,
            string technicianId)
        {
            _requestService.AssignTechnician(requestId, technicianId);

            return Ok("Technician assigned successfully.");
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _requestService.DeleteRequest(id);

            return NoContent();
        }
    }
}