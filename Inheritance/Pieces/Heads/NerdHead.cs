using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Heads
{
    class NerdHead : Head
    {
        public bool Braces { get; set; }
        public bool Acne { get; set; }

        //Methods
        public void Pontificate()
        {
            Console.WriteLine($"The nerd wearing {Eyewear} and a {Hat} says, 'Actually...'");
        }
        
        public override void Greet()
        {
            if (Acne)
            {
                Console.WriteLine("The nerd with bad acne says hello.");
            } else
            {
                Console.WriteLine("The nerd says hello");
            }
        }
    }
}
