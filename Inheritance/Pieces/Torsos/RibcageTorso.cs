using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Torsos
{
    class RibcageTorso : Torso
    {
        public Condition Condition { get; set; }

        public RibcageTorso(bool hasArmsAttached, Condition condition)
        {
            Clothing = Clothing.Shirtless;
            Accessory = "Bones";
            Arms = hasArmsAttached ? 2 : 0;
            Color = Color.White;
            Condition = condition;
        }

        public override void Wave()
        {
            if (Arms > 0)
            {
                base.Wave();
            } else
            {
                Console.WriteLine($"The {Condition} skeleton rattles");
            }
        }

    }
}
