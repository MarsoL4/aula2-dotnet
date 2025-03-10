using Microsoft.EntityFrameworkCore;
using TDSKP.API.Infrastructure.Mappings;
using TDSKP.API.Infrastructure.Persistence;

namespace TDSKP.API.Infrastructure.Contexts
{
    public class PhotosContext(DbContextOptions<PhotosContext> options) : DbContext(options)
    {

        public DbSet<Photo> Photos { get; set; }

        override protected void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new PhotoMapping());
        }
    }
}
