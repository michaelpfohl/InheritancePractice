using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Legs
{
    class DiscoLegs : LegsBase
    {
        public DiscoLegs()
        {
            _genre = "Disco";
            Speed = 20;
            Covering = "Bell Bottom Jeans";
            Shoes = "Boogie Shoes";
        }
    }
}
