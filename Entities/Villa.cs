using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DummyWebApp.Domain.Entities
{
    public class Villa
    {
        [Key]
        public int Id { get; set; }
        [Required]
        public required string Name { get; set; }
        //[DisplayName("Display Order")]
        [Range(1, 100, ErrorMessage = "Display Order must be between 1 & 50 only!")]
        public int Occupancy { get; set; }
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [NotMapped]
        public IFormFile Image { get; set; }

        public int Sqft { get; set; }
        public int Price { get; set; }
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdateDate { get; set; }
        public IEnumerable<Amenity>? VillaAmenity { get; set; }
        [NotMapped]
        public bool IsAvailable { get; set; } = true;

    }

}
