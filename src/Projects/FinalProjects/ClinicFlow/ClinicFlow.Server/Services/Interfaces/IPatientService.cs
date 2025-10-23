// IPatientService.cs
using ClinicFlow.Shared.Models;

public interface IPatientService
{
    Task<List<Patient>> GetAllAsync();
    Task<Patient?> GetByIdAsync(int id);
    Task AddAsync(Patient patient);
    Task UpdateAsync(Patient patient);
    Task DeleteAsync(int id);
}
