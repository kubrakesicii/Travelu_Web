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
    public class TourDayConfig : IEntityTypeConfiguration<TourDay>
    {
        public void Configure(EntityTypeBuilder<TourDay> builder)
        {
            builder.Property(x => x.Order).IsRequired();
            builder.Property(x => x.Overview).IsRequired();
        }
    }
}
