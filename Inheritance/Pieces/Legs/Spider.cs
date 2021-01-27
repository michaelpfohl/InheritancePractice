using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Legs
{
    class Spider : LegsBase
    {
        public Spider()
        {
            Shoes = "Rollerskates";
            NumberOfLegs = 8;
            Speed = 100;
            Size = Size.Spider;
            _genre = "Shoegaze";
            Covering = "Tiny Hairs";
        }

        public override void Dance()
        {
            Console.WriteLine("The Spider bobs its head up and down with the wall of sound");
        }
    }
}
