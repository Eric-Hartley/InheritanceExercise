using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Bird
    // give this class 4 members that are specific to Bird
    // Set this class to inherit from your Animal Class
    internal class Bird : Animal
    {
        public bool canFly {  get; set; }
        public bool hasBeak {  get; set; }
        public string color { get; set; }
        public string lengthOfFeathers { get; set; }
    }
}
