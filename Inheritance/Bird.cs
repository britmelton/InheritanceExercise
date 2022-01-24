using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Bird: Animal // Create a class Bird, Set this class to inherit from your Animal Class
    {
        public Bird()
        {

        }
        
        public int Wings { get; set; }
        public bool HasBeak { get; set; }
        public bool HasClaws { get; set; }
        public bool CanFly { get; set; }         // give this class 4 members that are specific to Bird




        /*public static string ToYesNoString(this bool CanFly)
        {
            return CanFly ? "yes" : "no";
            
        }*/
    }
}
   

