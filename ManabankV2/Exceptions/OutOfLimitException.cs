using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Manabank.Exceptions
{
    public class OutOfLimitException : Exception
    {
        public OutOfLimitException(string Message): base(Message)
        { 
        }
    }
}
