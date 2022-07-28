using Microsoft.EntityFrameworkCore;
using Users_Service.Entities;


namespace UsersService.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Users> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-0G0Q5V4\SQLEXPRESS;Database=SHAURYA;Integrated Security=True;");
        }
    }
}

