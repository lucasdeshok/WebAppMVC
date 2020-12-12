using Microsoft.EntityFrameworkCore;
using senac_sjrp.Models;

namespace senac_sjrp.Repository
{
    public class PieMapping : IEntityTypeConfiguration<Pie>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Pie> builder)
        {
            builder.ToTable("TBL_TORTA");
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).HasColumnName("Id").ValueGeneratedOnAdd();
            builder.Property(x => x.Name).IsRequired().HasMaxLength(250);
            builder.Property(x => x.ShortDescription).IsRequired().HasMaxLength(250);
            builder.Property(x => x.LongDescription).HasMaxLength(700);
            builder.Property(x => x.ImageUrl).HasMaxLength(300);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Discount).IsRequired();
        }
    }

}