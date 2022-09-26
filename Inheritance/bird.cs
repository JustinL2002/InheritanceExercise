using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class bird : animal
    {
        public bird()
        {

        }
        public bool HasWings { get; set; }
        public bool HasBeak { get; set; }
        public string FeatherColor { get; set; }    
        public bool CanFly { get; set; }
    }
}
