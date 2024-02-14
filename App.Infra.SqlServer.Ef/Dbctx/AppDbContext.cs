
using App.Domain.Core.Passenger.Entities;
using Microsoft.EntityFrameworkCore;

namespace App.Infra.SqlServer.Ef.Dbctx;

public class AppDbContext:DbContext
{
    private const string ConnectionString = @"Server=DESKTOP-EHGP6HB\SQLEXPRESS;Initial Catalog=ByTicketDb;Integrated Security=True;MultipleActiveResultSets=True";
    public DbSet<Passenger> passengers { get; set; }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(ConnectionString).LogTo(Console.WriteLine);
        base.OnConfiguring(optionsBuilder);
    }
}
