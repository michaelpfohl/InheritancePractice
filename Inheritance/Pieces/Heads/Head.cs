using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance.Pieces.Heads
{
    //Base Class - Cannot be instantiated
    abstract class Head
    {
        //Properties
        public Color EyeColor { get; set; }
        public string Eyewear { get; set; }
        public string Hair { get; set; }
        public Gender Gender { get; set; }
        public string Hat { get; set; }

        //Methods - no implementation, only allowed on abstract classes
        public abstract void Greet();

        public void Talk(string wordsToSay)
        {
            Greet();
            Console.WriteLine($"The {GetType().Name} says {wordsToSay}");
        }
    }
}
