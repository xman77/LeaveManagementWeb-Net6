using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurationn.Entities
{
    public class UserSeedConfiguration : IEntityTypeConfiguration<Employee>
    {
        public void Configure(EntityTypeBuilder<Employee> builder)
        {
            var hasher = new PasswordHasher<Employee>();
            builder.HasData(
                new Employee
                {
                    Id = "33deb6cf-62f7-4884-9546-04518095f7aa",
                    Email = "admin@test.com",
                    NormalizedEmail = "ADMIN@TEST.COM",
                    NormalizedUserName="ADMIN@TEST.COM",
                    UserName="admin@test.com",
                    FirstName = "System",
                    LastName = "Admin",
                    PasswordHash = hasher.HashPassword(null,"P@ssword1"),
                    EmailConfirmed=true
                },
                new Employee
                {
                    Id = "33deb6cf-62f7-4884-9546-04518095f7ab",
                    Email = "user@test.com",
                    NormalizedEmail = "USER@TEST.COM",
                    NormalizedUserName = "USER@TEST.COM",
                    UserName = "user@test.com",
                    FirstName = "System",
                    LastName = "User",
                    PasswordHash = hasher.HashPassword(null, "P@ssword1"),
                    EmailConfirmed = true
                }
            );
        }
    }
}