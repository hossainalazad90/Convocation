using System;
using System.Collections.Generic;
using System.Text;

namespace Convocation.Data.Utilities
{
    [AttributeUsage(AttributeTargets.Class |AttributeTargets.Interface)]
    public class IgnoreEntityAttribute:Attribute
    {
    }
}
