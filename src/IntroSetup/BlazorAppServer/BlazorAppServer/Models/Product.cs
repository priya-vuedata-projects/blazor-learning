using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BlazorAppServer.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required, StringLength(100)]
        public string Name { get; set; } = string.Empty;

        [StringLength(250)]
        public string? Description { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        [Range(0.01, 100000)]
        public decimal Price { get; set; }

        [Required]
        public int DepartmentId { get; set; }

        [ForeignKey(nameof(DepartmentId))]
        public Department? Department { get; set; }

        public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
