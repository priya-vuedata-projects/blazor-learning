using System.ComponentModel.DataAnnotations;

namespace ClinicFlow.Shared.Models
{
    public class Patient
    {
        public int Id { get; set; }
        [Required, StringLength(100)]
        public string Name { get; set; } = "";
        public int Age { get; set; }
        public string Contact { get; set; } = "";
        public string Gender { get; set; } = "";
        public string Address { get; set; } = "";
    }
}
