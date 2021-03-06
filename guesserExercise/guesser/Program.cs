﻿using System;
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
        const string Navn = "Marco";

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
                            Console.WriteLine("Too little, too late.");
                        }

                        break;

                  
                    case "Marco":

                        Console.WriteLine("Hurraaaaaaaaayyyy!! You did it! The answer is indeed " + input);

                        break;

                    case "quit":
                        return;
                    
                    default:
                        Console.WriteLine("You are not making any sense...");
                        break;

                }


                if (Trial == MaxTrials)
                {
                    Console.WriteLine("You have used " + Trial + " trials, which is the max. Resistance is useless.");
                    Console.WriteLine("Try again. If you want.");
                    Environment.Exit(0);
                }

            }
        }
    }
}
