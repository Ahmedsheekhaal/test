using Microsoft.EntityFrameworkCore;
namespace Date;
using Models;

public class AppointmentsDbContext : DbContext
{
    public AppointmentsDbContext(DbContextOptions<AppointmentsDbContext> options) : base(options)
    {

    }

    public DbSet<User> Users { get; set; }
}