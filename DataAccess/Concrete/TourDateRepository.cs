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
    public class TourDateRepository : GenericRepository<TourDate>, ITourDateRepository
    {
        public TourDateRepository(TraveluContext context) : base(context)
        {
        }
    }
}
