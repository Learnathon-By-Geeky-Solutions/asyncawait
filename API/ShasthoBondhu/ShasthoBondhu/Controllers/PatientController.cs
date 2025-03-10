using Microsoft.AspNetCore.Mvc;
using ShasthoBondhu.Data;
using ShasthoBondhu.Models.Domain;
using ShasthoBondhu.Models.DTO;

namespace ShasthoBondhu.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
        private readonly ShasthoBondhuDbContext dbContext;

        public PatientController(ShasthoBondhuDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult GetAllPatients()
        {
            var patients = dbContext.Patients.ToList();
            return Ok(patients);
        }

        [HttpPost]
        public IActionResult AddPatient(PatientDTO patientDTO)
        {
            var patient = new Patient
            {
                Id = Guid.NewGuid(),
                Name = patientDTO.Name,
                Image = patientDTO.Image,
                Address = patientDTO.Address,
                Phone = patientDTO.Phone,
                Email = patientDTO.Email
            };

            dbContext.Patients.Add(patient);
            dbContext.SaveChangesAsync();

            return Ok(patient);
        }

    }
}
