using DesafioDotNET.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDotNET.Data.Mapping
{
    public class TransactionPixMap : IEntityTypeConfiguration<TransactionPix>
    {
        public void Configure(EntityTypeBuilder<TransactionPix> builder)
        {
            builder
               .HasKey(x => x.Id);

            builder
                .Property(p => p.Payer)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .Property(p => p.Receiver)
                .HasMaxLength(30)
                .IsRequired();

            builder
                .HasOne(p => p.Payer)
                .WithMany()
                .HasForeignKey(p => p.PayerId);

            builder
                .HasOne(r => r.Receiver)
                .WithMany()
                .HasForeignKey(r => r.ReceiverId);

        }
    }
}
