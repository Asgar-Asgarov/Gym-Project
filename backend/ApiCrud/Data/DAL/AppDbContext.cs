using Microsoft.EntityFrameworkCore;
using ApiCrud.Models;
using System.Reflection;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace ApiCrud.Data.DAL;

public class AppDbContext :IdentityDbContext<AppUser> 
{
    public AppDbContext(DbContextOptions options) : base(options)
    {
    }
    
    public DbSet<Product> Products { get; set; }
    public DbSet<Category> Categories { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {   
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);


        //Use seed
        modelBuilder.Seed();
    }
    
    

    
}