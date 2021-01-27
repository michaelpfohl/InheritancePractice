using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Heads
{
    class CoolHead : Head
    {
        //Properties


        //Methods
        public void Chill()
        {
            Console.WriteLine($"The {Gender} head with {Hair} hair is chilling with {Eyewear} on.");
        }

        public override void Greet()
        {
            Console.WriteLine($"The {Gender} head says 'What's up'");
        }

        public void Info()
        {
            Console.WriteLine($"The Cool Head is {Gender} with {Hair} hair and {Eyewear}.");
        }
    }
}
