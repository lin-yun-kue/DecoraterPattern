using BreakfastDecoration.SuperClass;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakfastDecoration.decorator
{
    public class Cheese : BreakfastDecorator
    {
        private Breakfast _breakfast;

        public Cheese(Breakfast breakfast)
        {
            this._breakfast = breakfast;
        }

        public override string description { get => "Cheese"; }

        public override double cost()
        {
            return 10;
        }
    }
}
