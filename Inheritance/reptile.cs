using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    internal class reptile : animal
    {
        public reptile()
        {

        }
        public bool IsColdBlooded { get; set; }
        public bool LaysEggs { get; set; }
        public bool HasEyes { get; set; }
        public string ScaleColor { get; set; }

    }
}
