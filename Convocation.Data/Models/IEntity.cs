using Convocation.Data.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convocation.Data.Models
{
    [IgnoreEntity]
    public  interface IEntity<T>:IBaseEntity
    {
        T Id { get; set; }
    }
}
