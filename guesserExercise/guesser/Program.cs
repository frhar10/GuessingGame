using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace guesser
{
    class Guesser
    {
        // the "const" keyword makes the value of the variable final, meaning it can never be modified
        // a variable with "const" acts also as if it had the "static" modifier, meaning it can be accessed without needing to instantiate an object
        const int MaxTrials = 10;
        public static int Trial = 0;

        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Guessing Game!");
            Console.WriteLine("Your options are: NONE! HA!");
            Console.WriteLine("Oh wait - you have to GUESS your options! MUHAHAHA");

            while (Trial <= MaxTrials)
            {
                string input = Console.ReadLine();
                switch (input)
                {
                    case "GUESS":
                        Console.WriteLine("Guess what?");

                        string guessInput = Console.ReadLine();

                        if (guessInput == "42")
                        {
                            Console.WriteLine("42!? That cost you 1 of your " + (MaxTrials - Trial) + " trials..");

                            Trial += 1;
                        }
                        else
                        {
                            Console.WriteLine("Nope, invalid game!");
                        }

                        break;

                    /*
                case "add":
                    Console.WriteLine("Tilføj spil");

                    Console.WriteLine("Game name: ");
                    string name = Console.ReadLine();

                    Console.WriteLine("Game price: ");
                    string price = Console.ReadLine();
                    float pr = float.Parse(price);

                    Console.WriteLine("Game description: ");
                    string description = Console.ReadLine();

                    Console.WriteLine("Game genre: ");
                    string genre = Console.ReadLine();

                    Game game = new Game(genre, name, pr, description);
                    store.AddGame(game);

                    break;

                case "quit":
                    return;
                    */
                    default:
                        Console.WriteLine("You are not making any sense...");
                        break;

                }


                if (Trial == MaxTrials)
                {
                    Console.WriteLine("You have used " + Trial + " trials, which is the max. Resistance is useless.");

                }

                Console.WriteLine("No more trials. Try again. If you want.");

            }
        }
    }
}
