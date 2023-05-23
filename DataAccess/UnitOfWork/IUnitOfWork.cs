using DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IUserRepository Users { get; } 
        IBlogRepository Blogs { get; }
        IDestinationRepository Destinations { get; }
        ITourCommentRepository TourComments { get; }
        ITourDateRepository TourDates { get; }
        ITourDayRepository TourDays { get; }
        ITourImageRepository TourImages { get; }
        ITourRepository Tours { get; }
        IUserBookingRepository UserBookings { get; }
        
        int SaveChanges();
    }
}
