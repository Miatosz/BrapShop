using Microsoft.AspNetCore.Identity;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BrapShop.Data.models
{
    public class ApplicationUser : IdentityUser
    {

        public ICollection<Order> Orders { get; set; } = new List<Order>();
        public Address Address { get; set; } = new Address();
        public Wishlist Wishlist { get; set; } = new Wishlist();
        public Cart Cart { get; set; } = new Cart();

        [Required]
        public string UserRole { get; set; } = string.Empty;
    }
}
