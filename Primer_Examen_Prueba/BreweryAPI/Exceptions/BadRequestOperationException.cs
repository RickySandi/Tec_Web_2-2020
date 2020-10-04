using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Primer_Examen.Exceptions
{
    public class BadRequestOperationException : Exception
    {
        public BadRequestOperationException(string message)
            : base(message)
        {
        }
    }
}
