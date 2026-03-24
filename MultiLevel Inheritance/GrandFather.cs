using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLevel_Inheritance
{
    internal class GrandFather
    {
        public GrandFather()
        {
            Console.WriteLine("GrandFather's constructor called.");
        }

        public void AncestralTrait()
        {
            Console.WriteLine("This is an ancestral trait from the GrandFather.");
        }
    }
}
