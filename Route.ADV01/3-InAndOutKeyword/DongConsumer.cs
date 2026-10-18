using System;
using System.Collections.Generic;
using System.Text;

namespace Route.ADV01._3_InAndOutKeyword
{
    internal class DongConsumer : IConsumer<Dog>
    {
        public void Consume(Dog animal)
        {
            Console.WriteLine("Consuing Dog");
        }
    }
}
