using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace TF_NET_2026_IAC_Bend.Db
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData([
                    new Product { Id = 1, Name = "Product 1", ImageUrl = "https://example.com/product1.jpg" },
                    new Product { Id = 2, Name = "Product 2", ImageUrl = "https://example.com/product2.jpg" },
                    new Product { Id = 3, Name = "Product 3", ImageUrl = "https://example.com/product3.jpg" }
                ]);
        }
    }
}
