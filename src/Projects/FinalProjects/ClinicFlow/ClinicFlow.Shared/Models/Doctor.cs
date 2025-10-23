using System.ComponentModel.DataAnnotations;

namespace ClinicFlow.Shared.Models
{
    public class Doctor
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; } = "";
        public string Specialty { get; set; } = "";
        public string Contact { get; set; } = "";
    }
}
