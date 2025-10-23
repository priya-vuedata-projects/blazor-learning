using ClinicFlow.Server.Data;
using ClinicFlow.Shared.Models;
using Microsoft.EntityFrameworkCore;

public class AppointmentService : IAppointmentService
{
    private readonly ClinicDbContext _db;

    public AppointmentService(ClinicDbContext db) => _db = db;

    public async Task<List<Appointment>> GetAllAsync() =>
        await _db.Appointments
                 .Include(a => a.Patient)
                 .Include(a => a.Doctor)
                 .ToListAsync();

    public async Task<Appointment?> GetByIdAsync(int id) =>
        await _db.Appointments
                 .Include(a => a.Patient)
                 .Include(a => a.Doctor)
                 .FirstOrDefaultAsync(a => a.Id == id);

    public async Task AddAsync(Appointment appointment)
    {
        _db.Appointments.Add(appointment);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Appointment appointment)
    {
        _db.Appointments.Update(appointment);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var appointment = await _db.Appointments.FindAsync(id);
        if (appointment != null)
        {
            _db.Appointments.Remove(appointment);
            await _db.SaveChangesAsync();
        }
    }
}
