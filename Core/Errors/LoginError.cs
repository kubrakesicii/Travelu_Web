using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Errors
{
    public class LoginError : Exception
    {
        private int StatusCode { get; set; }
        public LoginError() : base("LOGINERROR")
        {
            StatusCode = 200;
        }
    }
}
