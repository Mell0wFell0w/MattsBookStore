using Microsoft.EntityFrameworkCore;
using static System.Reflection.Metadata.BlobBuilder;
using System.Collections.Generic;

namespace MattsBookStore.Models
{
    public class MattsBooksContext : DbContext
    {
        public MattsBooksContext(DbContextOptions<MattsBooksContext> options) : base(options) { }

        public DbSet<Books> Books { get; set; }
    }
}