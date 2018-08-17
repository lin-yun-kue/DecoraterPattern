using BreakfastDecoration.SuperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastDecoration.component
{
    public class Toast : Breakfast
    {
        public Toast()
        {
            this.description = "吐司";
        }

        public override double cost()
        {
            return 10;
        }
    }
}
