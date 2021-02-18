using Convocation.Data.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convocation.Data.Models
{
    [IgnoreEntity]
    public abstract class AuditableEntity<T>:Entity<T>,IAuditableEntity
    {
    }
}
