using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Reptile
    // give this class 4 members that are specific to Reptile
    // Set this class to inherit from your Animal Class
    internal class Reptile : Animal
    {
        public bool hidesUnderground { get; set; }
        public string defenseMechanism { get; set; }
        public string methodOfTravel { get; set; }
        public bool hasFangs { get; set; }
    }
}
