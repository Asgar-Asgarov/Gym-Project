using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCrud.Data.Configurations;

public class ProductConfigurations : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.Property(p=>p.Name).HasMaxLength(50).IsRequired(true);
        builder.Property(c=>c.ImageUrl).IsRequired(false);
        builder.Property(p=>p.Price).IsRequired(true);
        builder.Property(p=>p.CreatedTime).HasDefaultValueSql("GetUtcDate()");
        builder.Property(p=>p.UpdatedTime).HasDefaultValue(DateTime.UtcNow);
    }

    
}