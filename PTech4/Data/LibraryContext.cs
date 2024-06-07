using Microsoft.EntityFrameworkCore;

namespace PTech4.Data
{
    public class LibraryContext : DbContext
    {
        public LibraryContext(DbContextOptions<LibraryContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<PTech4.Data.Book>()
                .HasIndex(u => u.ISBN)
                .IsUnique();
        }
        public DbSet<PTech4.Data.Author> Author { get; set; } = default!;
        public DbSet<PTech4.Data.Publisher> Publisher { get; set; } = default!;
        public DbSet<PTech4.Data.Book> Book { get; set; } = default!;
    }
}
