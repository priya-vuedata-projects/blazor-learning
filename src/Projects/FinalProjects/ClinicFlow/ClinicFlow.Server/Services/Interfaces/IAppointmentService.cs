using ClinicFlow.Shared.Models;

public interface IAppointmentService
{
    Task<List<Appointment>> GetAllAsync();
    Task<Appointment?> GetByIdAsync(int id);
    Task AddAsync(Appointment appointment);
    Task UpdateAsync(Appointment appointment);
    Task DeleteAsync(int id);
}
