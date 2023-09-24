using Core_Project_Api.DAL.Entity;
using Microsoft.EntityFrameworkCore;

namespace Core_Project_Api.DAL.ApiContext
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=SCHEFEN\\SQLEXPRESS;database=CoreProjeApiDB;integrated security=true");
        }


        public DbSet<Category> categories { get; set; }
    }
}
