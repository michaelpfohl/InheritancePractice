using System;
using System.Collections.Generic;
using System.Text;
using Inheritance.Pieces.Heads;
using Inheritance.Pieces.Torsos;
using Inheritance.Pieces.Legs;

namespace Inheritance
{
    class MiniFigure
    {
        public Head Head { get; }
        public Torso Torso { get; }
        public LegsBase Legs { get; }
        public string Name { get; }

        public MiniFigure(Head head, Torso torso, LegsBase legs, string name)
        {
            Head = head;
            Legs = legs;
            Torso = torso;
            Name = name;
        }

        public void MeetSomeone()
        {
            Console.WriteLine($"Off in the distance, you see {Name}");
            Legs.Walk("forward");
            Torso.Wave();
            Head.Greet();
            Console.WriteLine($"Wasn't it nice meeting {Name}?");

        }
    }
}
