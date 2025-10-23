using ClinicFlow.Server.Data;
using ClinicFlow.Shared.Models;
using Microsoft.AspNetCore.SignalR;
using Microsoft.EntityFrameworkCore;

public class DoctorService : IDoctorService
{
    private readonly ClinicDbContext _db;
    private readonly IHubContext<ClinicHub> _hubContext;

    public DoctorService(ClinicDbContext db, IHubContext<ClinicHub> hubContext)
    {
        _db = db;
       // _hubContext = hubContext;
    }

    public async Task<List<Doctor>> GetAllAsync() =>
        await _db.Doctors.ToListAsync();

    public async Task<Doctor?> GetByIdAsync(int id) =>
        await _db.Doctors.FindAsync(id);

    public async Task AddAsync(Doctor doctor)
    {
        _db.Doctors.Add(doctor);
        await _db.SaveChangesAsync();

        //await _hubContext.Clients.All.SendAsync("ReceiveDashboardUpdate", "DoctorAdded");
    }

    public async Task UpdateAsync(Doctor doctor)
    {
        _db.Doctors.Update(doctor);
        await _db.SaveChangesAsync();

        //await _hubContext.Clients.All.SendAsync("ReceiveDashboardUpdate", "DoctorUpdated");
    }

    public async Task DeleteAsync(int id)
    {
        var doctor = await _db.Doctors.FindAsync(id);
        if (doctor != null)
        {
            _db.Doctors.Remove(doctor);
            await _db.SaveChangesAsync();

           // await _hubContext.Clients.All.SendAsync("ReceiveDashboardUpdate", "DoctorDeleted");
        }
    }
}
