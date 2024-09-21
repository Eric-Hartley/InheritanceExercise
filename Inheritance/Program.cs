using System;
using System.Security.Cryptography.X509Certificates;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common



            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var myBird = new Bird();

            myBird.canFly = true;
            myBird.color = "blue";
            myBird.sizeInCM = 25;
            myBird.name = "Blue Jay";
            myBird.lengthOfFeathersInCM = 12.2;
            myBird.hasBeak = true;

            Console.WriteLine($"A wild {myBird.name} was spotted in the park today. "
                + $"It was proven {myBird.canFly} that it could fly as it soared passed "
                + $"me with its short {myBird.lengthOfFeathersInCM}cm feathers. "
                + $"Its small {myBird.sizeInCM}cm body "
                + $"was nice to see, and it was {myBird.hasBeak}, they do have a beak.");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            var gecko = new Reptile();

            gecko.hasFangs = false;
            gecko.hidesUnderground = true;
            gecko.defenseMechanism = "Drops its tail";
            gecko.methodOfTravel = "Runs/walks on its legs";

            Console.WriteLine("Gecko Analysis:");
            Console.WriteLine("----------------");
            Console.WriteLine($"Fangs: {gecko.hasFangs}");
            Console.WriteLine($"Underground: {gecko.hidesUnderground}");
            Console.WriteLine($"Defense: {gecko.defenseMechanism}");
            Console.WriteLine($"Travel: {gecko.methodOfTravel}");
        }
    }
}
