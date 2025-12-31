using Microsoft.EntityFrameworkCore;
using TinyEditorDemo.Models;

namespace TinyEditorDemo.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) { }

        public DbSet<Article> Articles { get; set; }
    }
}
