﻿using Convocation.Data.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Convocation.Data.Models
{
    [IgnoreEntity]
    public abstract class Entity<T> : BaseEntity, IEntity<T>
    {
        public virtual T Id { get; set; }
    }
}
