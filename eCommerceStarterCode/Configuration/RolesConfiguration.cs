using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace eCommerceStarterCode.Configuration
{
    public class RolesConfiguration : IEntityTypeConfiguration<IdentityRole>
    {
        public void Configure(EntityTypeBuilder<IdentityRole> builder)
        {
            builder.HasData
            (
                new IdentityRole
                {
                    Name = "User",
                    NormalizedName = "USER",
                    Id = "c073f42c-79e8-41a6-a5d7-0ed41ae7aca0",
                    ConcurrencyStamp = "df8961da-91f7-4729-a4aa-312b6fcd7c8f"
                },
                new IdentityRole
                {
                    Name = "Admin",
                    NormalizedName = "ADMIN",
                     Id = "a85197de-2346-492e-861e-08b0370b485f",
                    ConcurrencyStamp = "27e54b6b-7578-4229-8a3e-7a5a5651df3b"
                }
            );
        }
    }
}
