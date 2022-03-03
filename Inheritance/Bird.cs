using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird: Animal 
    {
        public Bird()
        {

        }
        public int Wings { get; set; }
        public bool HasBeak { get; set; }
        public bool HasClaws { get; set; }
        public bool CanFly { get; set; }        

    }
}
   

