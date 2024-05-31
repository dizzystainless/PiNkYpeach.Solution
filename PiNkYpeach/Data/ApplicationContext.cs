using Microsoft.EntityFrameworkCore;
using PiNkYpeach.Web.Data.Entities;

namespace PiNkYpeach.Web.Data
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext (DbContextOptions<ApplicationContext> options) : base(options)
        {
             
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //User


            base.OnModelCreating(modelBuilder);
        }
    }
}
