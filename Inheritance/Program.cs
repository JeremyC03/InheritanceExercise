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




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            Bird bird1 = new Bird();
            bird1.HasBrain = true;
            bird1.HasHeart = true;
            bird1.Age = 10;
            bird1.Eyes = 2;
            bird1.HasFeathers = true;
            bird1.HasWings = true;
            bird1.CanFly = true;
            bird1.IsSmall = true;

            Console.WriteLine("Bird 1");
            Console.WriteLine($"Has a brain: {bird1.HasBrain}");
            Console.WriteLine($"Has a heart:{bird1.HasHeart}");
            Console.WriteLine($"Age:{bird1.Age}");
            Console.WriteLine($"Number of eyes: {bird1.Eyes}");
            Console.WriteLine($"Has feathers:{bird1.HasFeathers}");
            Console.WriteLine($"Has wings:{bird1.HasWings}");
            Console.WriteLine($"Can fly: {bird1.CanFly}");
            Console.WriteLine($"Is small: {bird1.IsSmall}");
            Console.WriteLine();

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */
            Reptile reptile1 = new Reptile();
            reptile1.HasBrain = true;
            reptile1.HasHeart = true;
            reptile1.Age = 15;
            reptile1.Eyes = 2;
            reptile1.HasScales = true;
            reptile1.HasTeeth = true;
            reptile1.HasTail = true;
            reptile1.Limbs = 4;

            Console.WriteLine("Reptile 1");
            Console.WriteLine($"Has a brain: {reptile1.HasBrain}");
            Console.WriteLine($"Has a heart:{reptile1.HasHeart}");
            Console.WriteLine($"Age:{reptile1.Age}");
            Console.WriteLine($"Number of eyes: {reptile1.Eyes}");
            Console.WriteLine($"Has scales:{reptile1.HasScales}");
            Console.WriteLine($"Has teeth:{reptile1.HasTeeth}");
            Console.WriteLine($"Has tail: {reptile1.HasTail}");
            Console.WriteLine($"Number of limbs: {reptile1.Limbs}");
        }
    }
}
