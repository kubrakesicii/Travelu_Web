using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configuration
{
    public class TourConfig : IEntityTypeConfiguration<Tour>
    {
        public void Configure(EntityTypeBuilder<Tour> builder)
        {
            builder.Property(x => x.Title).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Description).HasMaxLength(512).IsRequired();
            builder.Property(x => x.Overview).IsRequired();
            builder.Property(x => x.NumOfPeoplePerGroup).IsRequired();
            builder.Property(x => x.Latitude).HasMaxLength(256).IsRequired();
            builder.Property(x => x.Longitude).HasMaxLength(256).IsRequired();
        }
    }
}
