using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace TestTextAdventureExample
{
  public class Program
  {
        public static Player currentPlayer = new Player(); //creates a new instance of a player
        public static bool mainLoop = true;
       
        static void Main(string[] args)
        {
            Start();
            Encoutners.FirstEncounter();
            while (mainLoop) 
            {
                Encoutners.RandomEncounter();
            }

        }

        // we want our game to only start once
        static void Start()
        {
            Console.WriteLine("Chicken's Dungeon");
            Console.WriteLine("What is your name?");
            currentPlayer.name = Console.ReadLine();

            Console.Clear(); // clears the lines

            Console.WriteLine("You awake in a cold, stone, dark room. You feel dazed and are having trouble remembering");
            Console.WriteLine("anthing about your past.");
            if (currentPlayer.name == "")
            {
                Console.WriteLine("You know your name. Try to remember harder, you have to..."); //checking that there is a string and not a blank.
            }
            else
            {
                Console.WriteLine("You know your name is " + currentPlayer.name);
            }

            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You feel around in the darkness until you find the door handle. You feel some resistance as \n you turn the handle, but the rusty lock breaks with little effort. You see your captor \nstanding with his back to you outside the door.");
            


            
        }
  }
}
