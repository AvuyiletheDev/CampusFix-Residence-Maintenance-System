using CampusFix.Application.Services;
using CampusFix.Domain.Entities;
using Microsoft.AspNetCore.Mvc;

namespace CampusFix.Web.Controllers
{
    [ApiController]
    [Route("api/technicians")]
    public class TechniciansApiController : ControllerBase
    {
        private readonly TechnicianService _technicianService;

        public TechniciansApiController(TechnicianService technicianService)
        {
            _technicianService = technicianService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(_technicianService.GetAllTechnicians());
        }

        [HttpGet("{id}")]
        public IActionResult GetById(string id)
        {
            var technician = _technicianService.GetTechnicianById(id);

            if (technician == null)
            {
                return NotFound($"Technician with ID '{id}' was not found.");
            }

            return Ok(technician);
        }

        [HttpPost]
        public IActionResult Create([FromBody] Technician technician)
        {
            _technicianService.SaveTechnician(technician);

            return CreatedAtAction(nameof(GetById),
                new { id = technician.Id },
                technician);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(string id)
        {
            _technicianService.DeleteTechnician(id);

            return NoContent();
        }
    }
}