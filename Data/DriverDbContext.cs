using DriverLibrary.Entities;
using Microsoft.EntityFrameworkCore;

namespace DriverLibrary.Data;

public class DriverDbContext : DbContext
{
    public DbSet<Driver> Drivers { get; set; }

    public DriverDbContext(DbContextOptions<DriverDbContext> options)
    : base(options){}
}