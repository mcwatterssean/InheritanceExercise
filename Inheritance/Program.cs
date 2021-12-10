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
            Bird larry = new Bird()
            {
                Name = "Larry",
                Age = 5,
                Legs = 2,
                IsWarmBlooded = true,
                HasFeathers = true,
                CanFly = true,
                Wings = 2,
                Type = "Cockatoo"
            };

            Console.WriteLine($"{larry.Name} is a {larry.Age} year old {larry.Type} with {larry.Legs} legs and {larry.Wings} wings");
            Console.WriteLine($"Is {larry.Name} warmblooded? {larry.IsWarmBlooded}" +
                $"\nDoes {larry.Name} have feathers? {larry.HasFeathers}" +
                $"\r\nCan {larry.Name} fly? {larry.CanFly}");



            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Reptile lizard = new Reptile("Lizard", 50, 4, false, true, true, "detach their tail", "desert");

            Console.WriteLine($"\n\n\n\n\nA {lizard.Name} lives in the {lizard.Environment} and some can live up to {lizard.Age} years old! \r\nThey have {lizard.Legs} legs and can" +
                $" {lizard.Defense} when they feel in danger. \r\nAre they warmblooded? {lizard.IsWarmBlooded} " +
                $"\nDo they have tails and scales? {lizard.HasScales} {lizard.HasTail}  ");

        }
    }
}
