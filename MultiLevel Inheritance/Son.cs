using System;
using System.Collections.Generic;
using System.Text;

namespace MultiLevel_Inheritance
{
    internal class Son: Father
    {
        public Son()
        {
            Console.WriteLine("Son's Constructor called.");
        }

        public void SonsTrait()
        {
            Console.WriteLine("This is a trait specific to Son");
        }
    }
}
