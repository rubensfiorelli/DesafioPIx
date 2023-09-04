using DesafioDotNET.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDotNET.Data.Mapping
{
    public class ReceiverMap : IEntityTypeConfiguration<Receiver>
    {
        public void Configure(EntityTypeBuilder<Receiver> builder)
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
