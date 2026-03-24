using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLevel_Inheritance
{
    internal class Father: GrandFather
    {
        public Father()
        {
            Console.WriteLine("Father's Constructor called.");
        }
        public void FathersTrait()
        {
            Console.WriteLine("This is a trait specific to the Father.");
        }
    }
}
