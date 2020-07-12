using DBEntity;
using Microsoft.EntityFrameworkCore;


namespace DBManager
{
    public class AppContext : DbContext
    {
        public DbSet<Log> Logs { get; set; }
        public DbSet<Enviroment> Enviroment { get; set; }
        public DbSet<Level> Level { get; set; }
        public DbSet<User> User { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) =>
             optionsBuilder.UseSqlServer(@"Server=.\SQLEXPRESS;Database=LOGGER;Integrated Security=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
