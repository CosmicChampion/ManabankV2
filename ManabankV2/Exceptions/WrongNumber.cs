using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManabankV2.Exceptions
{
    public class WrongNumber: Exception
    {
        public WrongNumber(string Message):base(Message) 
        { }
    }
}
