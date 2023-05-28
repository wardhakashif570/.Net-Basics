using AuthController.Controllers;
using Microsoft.EntityFrameworkCore;

namespace AuthController.Data
{
    public class UserAPIDbContext : DbContext
    {
        public UserAPIDbContext(DbContextOptions options) : base(options)
        {
        }
        public DbSet<OTPInfo> OTPInfos { get; set; }

        public DbSet<User> User { get; set; }
    }
}