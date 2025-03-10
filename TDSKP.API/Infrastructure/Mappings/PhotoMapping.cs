using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TDSKP.API.Infrastructure.Persistence;

namespace TDSKP.API.Infrastructure.Mappings
{
    public class PhotoMapping : IEntityTypeConfiguration<Photo>
    {
        public void Configure(EntityTypeBuilder<Photo> builder)
        {
            throw new NotImplementedException();
        }
    }
}
