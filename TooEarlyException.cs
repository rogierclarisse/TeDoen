using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeDoen
{
    internal class TooEarlyException : Exception
    {
        public TooEarlyException()
        {
        }

        public TooEarlyException(string message) : base(message)
        {
            message = "Het tijdstip kan niet in het verleden liggen";
        }

        public TooEarlyException(string message, Exception inner) : base(message, inner)
        {
        }
    }
}
