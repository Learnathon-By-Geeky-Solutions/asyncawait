using Microsoft.AspNetCore.Mvc;
using ShasthoBondhu.Dto;
using ShasthoBondhu.Service.Interfaces;

namespace ShasthoBondhu.Api.Controllers
{
    /// <summary>
    /// Controller for managing patients.
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public sealed class PatientController(IPatientService patientService) : ControllerBase
    {

        private readonly IPatientService _patientService = patientService;

        /// <summary>
        /// Retrieves all patients.
        /// </summary>
        /// <returns>A list of patients.</returns>
        [HttpGet]
        public async Task<IActionResult> GetAllPatients()
        {
            var patients = await _patientService.GetAllAsync();
            return Ok(patients);
        }

        /// <summary>
        /// Retrieves a patient by their ID.
        /// </summary>
        /// <param name="id">The ID of the patient.</param>
        /// <returns>The patient with the specified ID.</returns>
        [HttpGet("{id}")]
        public async Task<IActionResult> GetPatientById(int id)
        {
            var patient = await _patientService.GetByIdAsync(id);
            return Ok(patient);
        }

        /// <summary>
        /// Adds a new patient.
        /// </summary>
        /// <param name="patientdto">The patient data transfer object.</param>
        /// <returns>The newly created patient.</returns>
        [HttpPost]
        public async Task<IActionResult> AddPatient(PatientDto patientdto)
        {
            var result = await _patientService.AddAsync(patientdto);
            return CreatedAtAction(nameof(GetPatientById), new { id = result.patientId }, result);
        }
    }
}
