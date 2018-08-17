using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastDecoration.SuperClass
{
    public abstract class Breakfast
    {
        public virtual string description { get; set; }

        public abstract double cost();
    }
}
