using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;

namespace Riksbyggen.Backend.Models
{
    public class Apartment
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Company))]
        public int CompanyId { get; set; }

        [Required]
        public string Address { get; set; } = null!;

        public ICollection<Contract> Contracts { get; set; } = [];

    }
}
