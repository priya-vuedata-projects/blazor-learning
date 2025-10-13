using System.ComponentModel.DataAnnotations;

namespace BlazorAppServer.Models
{
    public class Department
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Description { get; set; }

        public ICollection<Product>? Products { get; set; }
    }
}
