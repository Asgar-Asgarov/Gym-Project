using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApiCrud.Data.Configurations;

public class CategoryConfiguration : IEntityTypeConfiguration<Category>
{
    public void Configure(EntityTypeBuilder<Category> builder)
    {
        builder.Property(c => c.Name).HasMaxLength(50).IsRequired(true);
        builder.Property(c => c.Desc).HasMaxLength(300).IsRequired(false);
        builder.Property(c => c.ImageUrl).HasMaxLength(50).IsRequired(true);
        builder.Property(p => p.CreatedTime).HasDefaultValueSql("GetUtcDate()");
        builder.Property(p => p.UpdatedTime).HasDefaultValueSql("GetUtcDate()");

    }
}