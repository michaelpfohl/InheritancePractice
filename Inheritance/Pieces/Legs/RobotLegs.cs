using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Legs
{
    class RobotLegs : LegsBase
    {
        public RobotLegs()
        {
            Covering = "Metal";
            _genre = "Techno";
            NumberOfLegs = 3;
            Speed = 4;
        }

        public override void Dance()
        {
            Console.WriteLine("The Robot does what must be the mathmatically perfect definition of 'dancing'");
        }
    }
}
