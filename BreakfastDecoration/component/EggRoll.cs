using BreakfastDecoration.SuperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastDecoration.component
{
    public class EggRoll : Breakfast
    {
        public EggRoll()
        {
            this.description = "EggRoll";
        }

        public override double cost()
        {
            return 15;
        }
    }
}
