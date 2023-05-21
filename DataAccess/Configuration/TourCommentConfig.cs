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
    public class TourCommentConfig : IEntityTypeConfiguration<TourComment>
    {
        public void Configure(EntityTypeBuilder<TourComment> builder)
        {
            builder.Property(x => x.Point).IsRequired();
            builder.Property(x => x.Text).HasMaxLength(512).IsRequired();
        }
    }
}
