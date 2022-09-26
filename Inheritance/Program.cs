using System;

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
            var bird1 = new bird();
            {
                bird1.HasWings = true;
                bird1.HasBeak = true;
                bird1.FeatherColor = "white";
                bird1.CanFly = true;
                Console.WriteLine($"Has wings?:{bird1.HasWings}");
                Console.WriteLine($"Has beak?:{bird1.HasBeak}");
                Console.WriteLine($"Feather color is {bird1.FeatherColor}");
                Console.WriteLine($"Can fly?:{bird1.CanFly}");
            }
           
            var reptile1 = new reptile();
            {
                reptile1.IsColdBlooded = true;
                reptile1.LaysEggs = true;
                reptile1.HasEyes = true;
                reptile1.ScaleColor = "brown";
                Console.WriteLine($"Is cold blooded?:{reptile1.IsColdBlooded}");
                Console.WriteLine($"Lays eggs?:{reptile1.LaysEggs}");   
                Console.WriteLine($"Has eyes?:{reptile1.HasEyes}");
                Console.WriteLine($"Scale color is {reptile1.ScaleColor}");
            }
            

            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
        }
    }
}
