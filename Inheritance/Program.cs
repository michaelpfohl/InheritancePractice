using System;
using Inheritance.Pieces;
using Inheritance.Pieces.Heads;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            var coolHead = new CoolHead();
            coolHead.Eyewear = "Sunglasses";
            coolHead.Hair = "Long";
            coolHead.Gender = Gender.Female;

            var nerdHead = new NerdHead();
            nerdHead.Acne = true;
            nerdHead.Hat = "Fedora";

            var skull = new SkullHead { Color = Color.Red, Condition = Condition.Flaming };

            var heads = new Head[] { coolHead, nerdHead, skull };

            foreach(var head in heads)
            {
                head.Talk("C# is pretty damn cool!");
            }
        }
    }
}
