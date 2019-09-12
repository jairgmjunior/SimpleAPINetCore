using APIS.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace APIS.Data.Maps
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.ToTable("Products");
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Descricao).IsRequired().HasMaxLength(1024).HasColumnType("varchar(1024)");
            builder.Property(p => p.Price).IsRequired().HasColumnType("money");
            builder.Property(p => p.Title).IsRequired().HasMaxLength(255).HasColumnType("varchar(255)");
        }
    }
}