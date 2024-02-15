
using App.Domain.Core.Passenger.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.SqlServer.Ef.Dbctx;

public class AppDbContext:DbContext
{
    private const string ConnectionString = @"Server=DESKTOP-EHGP6HB\SQLEXPRESS;database= ByTicketDb;Trusted_Connection=True;TrustServerCertificate=True;Integrated Security=True;";
                                            
    
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseSqlServer(ConnectionString);
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
    public DbSet<Passenger> passengers { get; set; }
}
