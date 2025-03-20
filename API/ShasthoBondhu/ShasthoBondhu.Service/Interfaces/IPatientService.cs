using ShasthoBondhu.Dto;

namespace ShasthoBondhu.Service.Interfaces
{
    public interface IPatientService
    {
        Task<List<PatientDto>> GetAllAsync();

        Task<PatientDto?> GetByIdAsync(int id);

        Task<(bool success, int patientId)> AddAsync(PatientDto patient);
    }
}
