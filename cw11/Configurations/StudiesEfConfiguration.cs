using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using cw11.Models;

namespace cw11.Configurations
{
    public class StudiesEfConfiguration : IEntityTypeConfiguration<Studies>
    {
        public void Configure(EntityTypeBuilder<Studies> builder)
        {
            builder
            .HasKey(e => e.IdStudies); //[Key]

            builder
                        .Property(e => e.Name)
                        .HasMaxLength(100) //[MaxLength(100)]
                        .IsRequired(); // [Required]

            var dictStudies = new List<Studies>();
            dictStudies.Add(new Studies { IdStudies = 1, Name = "IT", Description = "AAA" });
            dictStudies.Add(new Studies { IdStudies = 2, Name = "Graphic design", Description = "BBB" });

            builder
                        .HasData(dictStudies);
        }
    }
}
