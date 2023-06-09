using ApiCrud.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace ApiCrud.Data.Configurations
{
    public class BlogDetailConfiguration
    {
        public void Configure(EntityTypeBuilder<BlogDetail> builder)
        {
            builder.Property(b => b.Name).HasMaxLength(50).IsRequired(true);
            builder.Property(b => b.Description).HasMaxLength(50).IsRequired(true);          
            builder.Property(b => b.ImageUrl).IsRequired(true);

        }

    }
}