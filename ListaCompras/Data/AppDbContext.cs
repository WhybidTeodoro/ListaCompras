using ListaCompras.Models;
using Microsoft.EntityFrameworkCore;

namespace ListaCompras.Data;

public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions options) : base(options){}

    public DbSet<User> Users { get; set; }
    public DbSet<ShoppingList> ShoppingLists { get; set; }
    public DbSet<ShoppingItem> ShoppingItems { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);

        modelBuilder.Entity<User>().Property(u => u.Email).IsRequired();

        modelBuilder.Entity<ShoppingList>().HasOne(l => l.User)
            .WithMany(u => u.ShoppingLists).HasForeignKey(l => l.UserId);

        modelBuilder.Entity<ShoppingList>().Property(l => l.Title).IsRequired();

        modelBuilder.Entity<ShoppingItem>().HasOne(i => i.ShoppingList)
            .WithMany(l => l.Items).HasForeignKey(i => i.ShoppingListId);

        modelBuilder.Entity<ShoppingItem>().Property(i => i.Name).IsRequired();

        modelBuilder.Entity<ShoppingItem>().Property(i => i.UnitPrice).HasPrecision(10, 2);

        modelBuilder.Entity<ShoppingItem>().Property(i => i.TotalPrice).HasPrecision(10, 2);

        modelBuilder.Entity<ShoppingItem>().Property(i => i.Isbought).HasDefaultValue(false);


    }
}
