using System;
using Inheritance.Pieces;
using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Torsos;
using Inheritance.Pieces.Legs;

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

            var pirateWithHook = new PirateTorso(true);
            var pirateWithoutHook = new PirateTorso(false);
            var skeleton = new RibcageTorso(false, Condition.Old);

            var spiderLegs = new Spider();
            var discoLegs = new DiscoLegs();
            var robotLegs = new RobotLegs();

            var skullPirateSpider = new MiniFigure(skull, pirateWithHook, spiderLegs, "Bimple");
            skullPirateSpider.MeetSomeone();

        }
    }
}
