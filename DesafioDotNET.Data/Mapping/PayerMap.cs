using DesafioDotNET.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDotNET.Data.Mapping
{
    public class PayerMap : IEntityTypeConfiguration<Payer>
    {
        public void Configure(EntityTypeBuilder<Payer> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(p => p.Name)
                .HasMaxLength(30)
                .IsRequired();
        }
    }
}
