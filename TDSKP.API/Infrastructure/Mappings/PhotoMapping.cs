using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TDSKP.API.Infrastructure.Persistence;

namespace TDSKP.API.Infrastructure.Mappings
{
    public class PhotoMapping : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            builder
                .ToTable("Photos");

            builder
                .HasKey("Id");

            /*builder
                .Property(photo=> photo.User)
                .IsRequired();*/

            builder
                .Property(photo => photo.Url)
                .IsRequired();

            builder
                .Property(photo => photo.Date)
                .IsRequired();
        }
    }
}
