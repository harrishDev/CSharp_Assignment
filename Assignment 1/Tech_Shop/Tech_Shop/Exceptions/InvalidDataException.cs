using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tech_Shop.Exceptions
{
    public class InvalidDataException : ApplicationException
    {
        public InvalidDataException(string message) : base(message) { }
    }
}
