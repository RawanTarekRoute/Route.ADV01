using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_GenericConstraint
{
    internal class Cat : Animal
    {
        public Cat(string name) : base(name)
        {
        }

        public override void Speak()
        {
            Console.WriteLine("Cat is speaking");

        }
    }
}
