using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class UserAccountException : Exception
    {
        public UserAccountException()
        {

        }
        public UserAccountException(string message) : base( message)
        {

        }
    }
}
