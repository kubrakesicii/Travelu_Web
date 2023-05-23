using DataAccess.Abstract;
using DataAccess.Context;
using DataAccess.Generic;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete
{
    public class TourDayRepository : GenericRepository<TourDay>, ITourDayRepository
    {
        public TourDayRepository(TraveluContext context) : base(context)
        {
        }
    }
}
