using Microsoft.EntityFrameworkCore;
using TesteLar.Domain.Entities;

namespace TesteLar.Infra.Context;

public class LarContext: DbContext
{
    public LarContext(DbContextOptions<LarContext> options) : base(options) { }

    public DbSet<PhoneType> PhoneType { get; set; }
    public DbSet<Person> Person { get; set; }
    public DbSet<Phone> Phone { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }

}
