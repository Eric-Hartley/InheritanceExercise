using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritance
{
    // Create a class Animal
    // give this class 4 members that all Animals have in common
    public class Animal
    {
        public Animal() { }

        public int numberOfLegs {  get; set; }
        public string name { get; set; }
        public string speed { get; set; }
        public double sizeInCM { get; set; }
    }
}
