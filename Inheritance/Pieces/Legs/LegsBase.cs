using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Legs
{
    class LegsBase
    {
        public string Covering { get; set; }
        public Size Size { get; set; }
        public int Speed { get; protected set; }
        public string Shoes { get; set; }
        public int NumberOfLegs { get; set; }

        protected string _genre { get; set; }

        public LegsBase()
        {
            NumberOfLegs = 2;
            Size = Size.Medium;
            Covering = "Pants";
            Speed = 1;
            _genre = "music";
        }

        public virtual void Dance()
        {
            var danceSpeed = Speed > 5 ? "Fast" : "Slow";
            Console.WriteLine($"The {GetType().Name} legs danced {danceSpeed} to {_genre}");
        }

        public void Walk(string direction)
        {
            Console.WriteLine($"The {GetType().Name} legs walk {Speed} spaces {direction}");
        }
    }
}
