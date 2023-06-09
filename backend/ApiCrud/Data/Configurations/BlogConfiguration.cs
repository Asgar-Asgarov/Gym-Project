using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ApiCrud.Data.Configurations
{
    public class BlogConfiguration
    {
        public void Configure(EntityTypeBuilder<Blog> builder)
        {
            builder.Property(p => p.Title).HasMaxLength(50).IsRequired(true);
            builder.Property(p => p.Author).HasMaxLength(50).IsRequired(true);
            builder.Property(c => c.ImageUrl).IsRequired(false);
            builder.Property(p => p.CreatedTime).HasDefaultValueSql("GetUtcDate()");
            builder.Property(p => p.UpdatedTime).HasDefaultValue(DateTime.UtcNow);
        }

    }
}