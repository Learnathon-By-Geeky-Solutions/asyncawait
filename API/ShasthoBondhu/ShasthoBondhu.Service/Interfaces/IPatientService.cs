using ShasthoBondhu.Dto;

namespace ShasthoBondhu.Service.Interfaces
{
    public interface IPatientService
    {
        Task<List<PatientDto>> GetAllAsync();

        Task<bool> AddAsync(PatientDto patient);
    }
}
