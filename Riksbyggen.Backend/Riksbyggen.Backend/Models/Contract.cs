using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Riksbyggen.Backend.Models
{
    public class Contract
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Apartment))]
        public int ApartmentId { get; set; }
        public Apartment Apartment { get; set; } = null!;

        [Required]
        public DateTime StartDate { get; set; }

        [Required]
        public DateTime EndDate { get; set; }
    }
}
