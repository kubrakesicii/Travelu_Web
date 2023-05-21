using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class TourComment : BaseEntity
    {
        public int Id { get; set; }

        public int TourId { get; set; }
        public Tour Tour { get; set; }

        public int Point { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }
        public string Text { get; set; }
    }
}
