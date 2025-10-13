using System.ComponentModel.DataAnnotations;

namespace BlazorAppServer.Models
{
    public class Customer
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(80)]
        public string Name { get; set; } = string.Empty;

        [EmailAddress, StringLength(120)]
        public string? Email { get; set; }

        [Phone, StringLength(20)]
        public string? Phone { get; set; }

        [StringLength(200)]
        public string? Address { get; set; }

        public DateTime JoinedDate { get; set; } = DateTime.Now;
    }
}
