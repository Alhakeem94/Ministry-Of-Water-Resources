using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using MOWwithMudBlazor.Models;

namespace MOWwithMudBlazor.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        public DbSet<CompaniesModel> ComapniesTable { get; set; }
        public DbSet<ProductsModel> ProductsTable { get; set; }


        
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            const string SuperAdmin_RoleId = "a18be9c0-aa65-4af8-bd17-00bd9344SA-Id";

            var Hasher = new PasswordHasher<IdentityUser>();
            builder.Entity<IdentityUser>().HasData(new IdentityUser
            {
                Id = "a18be9c0-aa65-4af8-bd17-as123AU-Id",
                UserName = "Moh54@gmail.com",
                NormalizedUserName = "MOH54@GMAIL.COM",
                Email = "Moh54@gmail.com",
                NormalizedEmail = "MOH54@GMAIL.COM",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString(),
                PasswordHash = Hasher.HashPassword(null , "Moh4321_"),

            });

            builder.Entity<IdentityRole>().HasData(new IdentityRole
            {
                Id = SuperAdmin_RoleId,
                Name = "SuperAdmin",
                NormalizedName = "SUPERADMIN",
                ConcurrencyStamp = Guid.NewGuid().ToString()
            });

            builder.Entity<IdentityUserRole<string>>().HasData(new IdentityUserRole<string>
            {
                UserId = "a18be9c0-aa65-4af8-bd17-as123AU-Id",
                RoleId = SuperAdmin_RoleId,
            });



        }


    }
}