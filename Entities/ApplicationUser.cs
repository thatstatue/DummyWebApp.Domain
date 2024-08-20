using Microsoft.AspNetCore.Identity;

namespace DummyWebApp.Domain.Entities
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
        public DateTime CreatedAt { get; set; }
        //public IEnumerable<Booking>? Bookings { get; set; }
    }
}
