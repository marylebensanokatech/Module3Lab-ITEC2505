
using System;

namespace TacoBurritoLab {
    class Program {
        static void Main(string[] args) {
            //Display a welcome message and prompt the user for input
            Console.WriteLine("Welcome to the Taco & Burrito Decision Maker!");
            Console.WriteLine("How hungry are you (1-10)? ");
            int hungerLevel = int.Parse(Console.ReadLine());

            //Decide what food to recommend based on the hunger level
            if (hungerLevel >= 8) {
                Console.WriteLine("You're super hungry! Order both tacos and burritos.");
            }
            else if (hungerLevel >= 5) {
                Console.WriteLine("You're moderately hungry. Go for tacos!");
            }
            else {
                Console.WriteLine("You're not that hungry. Opt for a burrito.");
            } //end else if

            //Display a final food recommendation
            string recommendation = (hungerLevel >= 5) ? "Tacos" : "Burrito";
            Console.WriteLine($"I recommend: {recommendation}");

            //Output a message to the user based on their hunger level
            switch (hungerLevel) {
                case 10:
                    Console.WriteLine("You're a burrito and a taco champion!");
                    break;
                case 9:
                case 8:
                    Console.WriteLine("Taco Time!");
                    break;
                case 7:
                case 6:
                case 5:
                    Console.WriteLine("Burrito it is!");
                    break;
                default:
                    Console.WriteLine("Maybe just grab a snack!");
                    break;
            } //end switch

        } //end main method 
    } //end Program class
} //end Namespace