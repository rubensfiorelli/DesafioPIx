using DesafioDotNET.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DesafioDotNET.Data.Mapping
{
    public class KeyPixMap : IEntityTypeConfiguration<KeyPix>
    {
        public void Configure(EntityTypeBuilder<KeyPix> builder)
        {
            builder
                .HasKey(x => x.Id);

            builder
                .Property(x => x.Description)
                .HasMaxLength(50)
                .IsRequired();

        }
    }
}
