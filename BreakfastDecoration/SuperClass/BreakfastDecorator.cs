using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastDecoration.SuperClass
{
    public abstract class BreakfastDecorator : Breakfast
    {
        public abstract override string description { get; }
    }
}
