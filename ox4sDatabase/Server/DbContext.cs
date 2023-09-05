using Microsoft.EntityFrameworkCore;
using ox4sDatabase.Shared;

namespace ox4sDatabase.Server
{
    public class DbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbContext(DbContextOptions<DbContext> options) : base(options) { }
        public DbSet<Article> Articles { get; set; }
    }
}
