using System.ComponentModel.DataAnnotations;

namespace Riksbyggen.Backend.Models
{
    public class Company
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; } = null!;

        public ICollection<Apartment> Contracts { get; set; } = [];
    }
}
