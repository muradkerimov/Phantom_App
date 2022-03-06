using Microsoft.EntityFrameworkCore;
using Phantom_App.Models;

namespace Phantom_App.DAL
{
    public class AppDbContext: DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Header> Headers { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<Message> Messages { get; set; }
    }
}
