using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Tour : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Overview { get; set; }
        public int NumOfPeoplePerGroup { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }

    }
}
