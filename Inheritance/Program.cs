using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Exercise Instructions
            /*Create a class Animal - give this class 4 members that all Animals have in common
             * Create a class Bird - give this class 4 members that are specific to Bird 
             * -Set this class to inherit from your Animal Class
             * Create a class Reptile - give this class 4 members that are specific to Reptile 
             * - Set this class to inherit from your Animal Class
             * Create an object of your Bird class - give values to your members using the object of your Bird class
             * - Creatively display the class member values 
             * Create an object of your Reptile class - give values to your members using the object of your Reptile class
             * - Creatively display the class member values*/
            #endregion

            Bird babyBird = new Bird() 
            {
                Name = "Songbird",
                Age = 1,
                Legs = 2,
                Sound = "chirp chirp",                  
                Wings = 2,
                HasBeak = true,
                HasClaws = true,
                CanFly = true,              
            };
            Reptile chameleon = new Reptile() 
            {
                Name = "Pascal",
                Age = 5,
                Legs = 4,
                Sound = "humpf",                    
                Scales = "color changing",
                ColdBlooded = true,
                ForkedTounge = false

            };
            Console.WriteLine($"My {babyBird.Name}\'s age is {babyBird.Age}. \nIt has {babyBird.Legs} legs and {babyBird.Wings} wings. " +
                $"\nIt is always singing {babyBird.Sound}.");

            Console.WriteLine($"\n{chameleon.Name} is the chameleon from Tangled.\n{chameleon.Name} is {chameleon.Age} years old, " +
                $"he has {chameleon.Legs} legs.\nHe makes a sound like {chameleon.Sound} and has very pretty {chameleon.Scales} scales.");
        }
    }
}
