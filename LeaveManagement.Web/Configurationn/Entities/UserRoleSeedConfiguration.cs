using LeaveManagement.Web.Data;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace LeaveManagement.Web.Configurationn.Entities
{
    public class UserRoleSeedConfiguration : IEntityTypeConfiguration<IdentityUserRole<string>>
    {
        public void Configure(EntityTypeBuilder<IdentityUserRole<string>> builder)
        {
            builder.HasData(
                new IdentityUserRole<string>
                { 
                    RoleId= "cac43a6e-f7bb-4448-baaf-ladd431ccbbf",
                    UserId= "33deb6cf-62f7-4884-9546-04518095f7aa"
                },
                new IdentityUserRole<string>
                {
                    RoleId = "cac43a7e-f7cb-4148-baaf-labb431eabbe",
                    UserId = "33deb6cf-62f7-4884-9546-04518095f7ab"
                }
                );
        }
    }
}