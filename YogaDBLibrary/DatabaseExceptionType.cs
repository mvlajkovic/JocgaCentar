using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YogaDBLibrary
{
    public enum DatabaseExceptionType
    {
        None = 0,
        Exception = 1,
        SqlException = 2,
        DbUpdateException = 3,
        DbUpdateConcurrencyException = 4,
        DbEntityValidationException = 5,
        NotSupportedException = 6,
        ObjectDisposedException = 7,
        InvalidOperationException = 8

    }
}
