using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Heads
{
    class SkullHead : Head
    {
        //Properties
        public Color Color { get; set; }
        public Condition Condition { get; set; }


        public void Wail()
        {
            Console.Write($"The {Condition} {Color} skull wails violently");
        }

        public override void Greet()
        {
            if (Condition == Condition.Flaming)
            {
                Console.WriteLine($"The flaming {Color} skull smolders in your direction.");
            }
            else
            {
                Console.WriteLine($"The {Condition} skull turns to you and says 'Hello'");
            }
        }
    }
}
