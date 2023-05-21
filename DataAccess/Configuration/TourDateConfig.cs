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
    public class TourDateConfig : IEntityTypeConfiguration<TourDate>
    {
        public void Configure(EntityTypeBuilder<TourDate> builder)
        {
            builder.Property(x => x.Date).IsRequired();
            builder.Property(x => x.PricePerPerson).IsRequired();
        }
    }
}
