using Microsoft.EntityFrameworkCore;
using ModelClasses.Login_Classes;

namespace ConcreteClass
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
        }

        public DbSet<Admin_Login> admin_login {  get; set; }
    }
}
