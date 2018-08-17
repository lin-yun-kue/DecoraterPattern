using BreakfastDecoration.SuperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastDecoration.decorator
{
    public class Hammer : BreakfastDecorator
    {
        private Breakfast _breakfast;

        public Hammer(Breakfast breakfast)
        {
            this._breakfast = breakfast;
        }

        public override string description => "Hammer";

        public override double cost()
        {
            return 20;
        }
    }
}
