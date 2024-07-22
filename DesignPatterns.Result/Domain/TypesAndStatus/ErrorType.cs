using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Result.Domain.EstatusYTipos
{
    internal enum ErrorType
    {
        None = -1,
        NullValue = 0,
        NotFound = 1,
        InvalidOperation = 2
    }
}
