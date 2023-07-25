using BrapShop.Data.models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace BrapShop.Data
{
    public class AppIdentityDbContext : IdentityDbContext<ApplicationUser>
    {
        public AppIdentityDbContext(DbContextOptions<AppIdentityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Order> Orders { get; set; }
        public DbSet<Address> Addresses { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<Wishlist> Wishlists { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<CartItem> CartItems { get; set; }
        public DbSet<Cart> Carts { get; set; }




        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{

        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.Entity<ApplicationUser>(b =>
        //        b.HasMany(e => e.Orders).WithOne());
        //    modelBuilder.Entity<ApplicationUser>().Property(e => e.Address);

        //    //modelBuilder.Entity<ApplicationUser>(b =>
        //    //    b.HasOne(e => e.Address) .WithOne(a => a.ApplicationUser).HasForeignKey<Address>(c => c.ApplicationUserID)) ;
        //}
    }
}