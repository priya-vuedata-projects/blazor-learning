namespace ClinicFlow.Shared.Models
{
    public enum AppointmentStatus { Scheduled, Completed, Cancelled }

    public class Appointment
    {
        public int Id { get; set; }
        public DateTime DateTime { get; set; }
        public int DoctorId { get; set; }
        public Doctor? Doctor { get; set; }
        public int PatientId { get; set; }
        public Patient? Patient { get; set; }
        public AppointmentStatus Status { get; set; }
        public string Notes { get; set; } = "";
    }
}
