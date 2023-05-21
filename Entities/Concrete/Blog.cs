using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities.Concrete
{
    public class Blog : BaseEntity
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }  //html
        public string ImagePath { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
