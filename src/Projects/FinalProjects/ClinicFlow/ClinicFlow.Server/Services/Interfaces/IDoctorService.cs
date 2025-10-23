using ClinicFlow.Shared.Models;

public interface IDoctorService
{
    Task<List<Doctor>> GetAllAsync();
    Task<Doctor?> GetByIdAsync(int id);
    Task AddAsync(Doctor doctor);
    Task UpdateAsync(Doctor doctor);
    Task DeleteAsync(int id);
}
