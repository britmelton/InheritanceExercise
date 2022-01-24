using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            Bird babyBird = new Bird() //Create an object of your Bird class
            {
                Name = "Songbird",
                Age = 1,
                Legs = 2,
                Sound = "chirp chirp",                  //give values to your members using the object of your Bird class
                Wings = 2,
                HasBeak = true,
                HasClaws = true,
                CanFly = true,
                

            };
            
            //Creatively display the class member values 
            

            


            Reptile chameleon = new Reptile() //Create an object of your Reptile class
            {
                Name = "Pascal",
                Age = 5,
                Legs = 4,
                Sound = "humpf",                    //give values to your members using the object of your Reptile class
                Scales = "color changing",
                ColdBlooded = true,
                ForkedTounge = false

            };
            //Creatively display the class member values 

            Console.WriteLine($"My {babyBird.Name}\'s age is {babyBird.Age}. \nIt has {babyBird.Legs} legs and {babyBird.Wings} wings. \nIt is always singing {babyBird.Sound}.");

            Console.WriteLine($"\n{chameleon.Name} is the chameleon from Tangled.\n{chameleon.Name} is {chameleon.Age} years old, he has {chameleon.Legs} legs.\nHe makes a sound like {chameleon.Sound} and has very pretty {chameleon.Scales} scales.");









        }
    }
}
