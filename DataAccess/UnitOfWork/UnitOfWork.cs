using DataAccess.Abstract;
using DataAccess.Concrete;
using DataAccess.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly TraveluContext _context;

        private readonly IUserRepository _userRepository;
        private readonly IBlogRepository _blogRepository;
        private readonly IDestinationRepository _destinationRepository;
        private readonly ITourCommentRepository _tourCommentRepository;
        private readonly ITourDateRepository _tourDateRepository;
        private readonly ITourDayRepository _tourDayRepository;
        private readonly ITourImageRepository _tourImageRepository;
        private readonly ITourRepository _tourRepository;
        private readonly IUserBookingRepository _userBookingRepository;

        public UnitOfWork(TraveluContext context)
        {
            if (context == null)
                throw new ArgumentNullException("dbContext can not be null.");
            _context = context;
        }

        public IUserRepository Users => _userRepository ?? new UserRepository(_context);

        public IBlogRepository Blogs => _blogRepository ?? new BlogRepository(_context);

        public IDestinationRepository Destinations => _destinationRepository ?? new DestinationRepository(_context);

        public ITourCommentRepository TourComments => _tourCommentRepository ?? new TourCommentRepository(_context);

        public ITourDateRepository TourDates => _tourDateRepository ?? new TourDateRepository(_context);

        public ITourDayRepository TourDays => _tourDayRepository ?? new TourDayRepository(_context);

        public ITourImageRepository TourImages => _tourImageRepository ?? new TourImageRepository(_context);

        public ITourRepository Tours => _tourRepository ?? new TourRepository(_context);

        public IUserBookingRepository UserBookings => _userBookingRepository ?? new UserBookingRepository(_context);

        public void Dispose()
        {
            _context.Dispose();
        }

        public int SaveChanges()
        {
            return _context.SaveChanges();
        }
    }
}
