
using App.Domain.Core.Bus.Entites;
using App.Domain.Core.Company.Entities;
using App.Domain.Core.Passenger.Entities;
using App.Domain.Core.Ticket.Entities;
using App.Domain.Core.Travel.Entities;
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
        //modelBuilder.Entity<Ticket>()
        //    .HasOne(t => t.Passenger)
        //    .WithMany(p => p.Ticket)
        //    .HasForeignKey(t => t.PassengerId);
    }
    public DbSet<Passenger> Passengers { get; set; }
    public DbSet<Bus> Buses { get; set; }
    public DbSet<Company> Companies{ get; set; }
    public DbSet<Ticket> Tickets  { get; set; }
    public DbSet<Travel> Travels { get; set; }
}
