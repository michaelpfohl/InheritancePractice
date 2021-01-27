using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Torsos
{
    abstract class Torso
    {
        public Clothing Clothing { get; set; }
        public Color Color { get; set; }
        public int Arms { get; set; } = 2;
        public string Accessory { get; set; }

        public virtual void Wave()
        {
            if (Arms > 0)
            {
                Console.WriteLine($"The {GetType().Name} waves");
            }
            else
            {
                Console.WriteLine($"Can't wave, no arms");
            }
        }
    }
}
