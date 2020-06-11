using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tuan2
{
    class AccessDeniedException :Exception
    {
        public AccessDeniedException()
        {

        }    
        public AccessDeniedException(string message) : base(message)
        {

        }
    }
}
