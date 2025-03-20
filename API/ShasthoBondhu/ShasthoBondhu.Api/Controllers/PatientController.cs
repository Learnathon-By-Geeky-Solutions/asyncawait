using Microsoft.AspNetCore.Mvc;
using ShasthoBondhu.Dto;
using ShasthoBondhu.Service.Interfaces;

namespace ShasthoBondhu.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PatientController(IPatientService patientService) : ControllerBase
    {
        private readonly IPatientService _patientService = patientService;

        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _patientService.GetAllAsync();
            return Ok(patients);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await _patientService.GetByIdAsync(id);

            if (patient == null)
            {
                return NotFound();
            }
            return Ok(patient);
        }

        [HttpPost]
        public async Task<IActionResult> AddPatient(PatientDto patientdto)
        {
            var result = await _patientService.AddAsync(patientdto);
            return CreatedAtAction(nameof(GetPatientById), new { id = result.patientId }, result);
        }
    }
}
