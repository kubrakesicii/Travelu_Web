using DataAccess.Configuration;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Context
{
    public class TraveluContext : DbContext
    {
        public TraveluContext(DbContextOptions<TraveluContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserConfig());
            modelBuilder.ApplyConfiguration(new BlogConfig());
            modelBuilder.ApplyConfiguration(new DestinationConfig());
            modelBuilder.ApplyConfiguration(new TourCommentConfig());
            modelBuilder.ApplyConfiguration(new TourConfig());
            modelBuilder.ApplyConfiguration(new TourDateConfig());
            modelBuilder.ApplyConfiguration(new TourDayConfig());
        }

        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<Blog> Blogs { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<Tour> Tours { get; set; }
        public virtual DbSet<TourComment> TourComments { get; set; }
        public virtual DbSet<TourDate> TourDates { get; set; }
        public virtual DbSet<TourDay> TourDays { get; set; }
        public virtual DbSet<TourImage> TourImages { get; set; }
        public virtual DbSet<UserBooking> UserBookings { get; set; }

        
    }
}
