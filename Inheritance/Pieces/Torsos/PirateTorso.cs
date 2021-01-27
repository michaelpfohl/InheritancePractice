using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Torsos
{
    class PirateTorso : Torso
    {
        public bool HasHook { get; private set; }

        public PirateTorso(bool hasHook)
        {
            Accessory = "Parrot";
            HasHook = hasHook;
        }

        public override void Wave()
        {
            if (HasHook)
            {
                Console.WriteLine($"The pirate beckons menacingly with their hook...");
            }
            else
            {
                base.Wave();
                Console.WriteLine($"the pirate gives you the finger");
            }
        }
    }
}
