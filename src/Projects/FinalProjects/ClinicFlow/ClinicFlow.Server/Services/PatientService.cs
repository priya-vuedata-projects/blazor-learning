// PatientService.cs
using ClinicFlow.Server.Data;
using ClinicFlow.Shared.Models;
using Microsoft.EntityFrameworkCore;

public class PatientService : IPatientService
{
    private readonly ClinicDbContext _db;

    public PatientService(ClinicDbContext db) => _db = db;

    public async Task<List<Patient>> GetAllAsync() =>
        await _db.Patients.ToListAsync();

    public async Task<Patient?> GetByIdAsync(int id) =>
        await _db.Patients.FindAsync(id);

    public async Task AddAsync(Patient patient)
    {
        _db.Patients.Add(patient);
        await _db.SaveChangesAsync();
    }

    public async Task UpdateAsync(Patient patient)
    {
        _db.Patients.Update(patient);
        await _db.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var patient = await _db.Patients.FindAsync(id);
        if (patient != null)
        {
            _db.Patients.Remove(patient);
            await _db.SaveChangesAsync();
        }
    }
}
