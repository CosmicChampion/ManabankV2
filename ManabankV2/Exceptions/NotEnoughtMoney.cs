using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManabankV2.Exceptions
{
    internal class NotEnoughtMoney : Exception
    {   
        public NotEnoughtMoney(string Message) : base(Message)
        {
        }
    }
}
