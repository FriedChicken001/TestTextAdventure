using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTextAdventureExample
{
    internal class Encoutners
    {
        static Random rand = new Random();
        //Encounters Generic - Generic coding for the encounters

        //Encounters - Scenarios
        public static void FirstEncounter() //voids do not return variables
        {
            Console.WriteLine("You throw open the door and grab a rusty, metal sword while charging towards your captor");
            Console.WriteLine("He turns..");
            Console.ReadKey();
            Combat(false, "Human Rouge", 1, 4);
            // is not random encounter, name of enemy, power of enemy, health of enemy.
        } 


        //Encounter Tools - Helps with the encounters
        public static void Combat(bool random, string name, int power, int health)
        {
            string n = ""; // name 
            int p = 0; // power
            int h = 0; // health
            if (random)
            {

            }
            else
            {
                n = name;
                p = power;
                h = health;
            }

            while(h > 0)
            {
                Console.Clear();
                Console.WriteLine(n);
                Console.WriteLine(p + "/" + h);



                Console.WriteLine("================");
                Console.WriteLine("| (A)ttack (D)efend  |");
                Console.WriteLine("| (R)un     (H)eal   |");
                Console.WriteLine("------------------------");
                Console.WriteLine("Potions: " + Program.currentPlayer.potions + " Health: " + Program.currentPlayer.health);
                string input = Console.ReadLine();

                if(input.ToLower() == "a" || input.ToLower() == "attack")
                {
                    //attack - takes full damange but outputs high damage

                    Console.WriteLine("With haste, you surge forth, slicing and dicing the enemy! \nAs you pass the " + n + " it strikes you back!");

                    int damage = p - Program.currentPlayer.armorValue; // basing Defense off of AC for the player

                    // Adding an if statement in the even damage is negative, this does not heal the player. 

                    if (damage < 0)
                    {
                        damage = 0;
                    }

                    int attack = rand.Next(0, Program.currentPlayer.weaponValue) + rand.Next(1, 4);
                    
                    // randomizing the attack roll here

                    // by starting with 0, the player will be able to do at leaset one damage. 

                    Program.currentPlayer.health -= damage; // this will subtract the damage the player took from the enemy. 
                    
                    
                    h -= attack; // this will subtract the damage the enemy took from the player. 

                    

                    Console.WriteLine("You lose " + damage + " health and deal " + attack + " damage");
                }

                else if (input.ToLower() == "d" || input.ToLower() == "defend")
                {
                    //defend -significatnly reduce damage taken, output low damage
                    Console.WriteLine("Seeing the incoming attack, you slightly and swiftly step to the side in order to manuever around the attack. The enemy caught you off guard and swings again. You raise your weapon to defend yourself from the attack.");

                    int damage = (p/4) - Program.currentPlayer.armorValue;

                    // adding an if statement in the event damage is negative due to the Player's AC. Setting it to 0 so that it does not heal the player. 
                    if (damage < 0)
                    {
                        damage = 0;
                    }

                    int attack = rand.Next(0, Program.currentPlayer.weaponValue /2); // diving the Player's attack by half so that they are doing significatnly lower damage as they are supposed to be defending. 

                    Console.WriteLine("You lose " + damage + "health and dealt " + attack + "damage to the enemy");
                    Program.currentPlayer.health -= damage;
                    h -= attack;
                }

                else if (input.ToLower() == "r" || input.ToLower() == "run")
                {
                    //run - attempt to escape, this should be a 50/50 shot

                   if(rand.Next(0, 2) == 0)
                    {
                        // this should be a fail
                        Console.WriteLine("As you sprint away from " + n + "you suddnely feel a weakness in your legs and trip. The fear of the battle is catching up on you and you failed to run away..");

                        int damage = p - Program.currentPlayer.armorValue;
                        if ( damage < 0)
                        {
                            damage = 0;
                        }

                        Console.WriteLine("You lose " + damage + " health and are unable to escape.");
                        Console.ReadKey();


                    }
                   else
                    {
                        // this should be a pass
                        Console.WriteLine("Running away with your life, " + n + " failed to match your speed as you turned the corner. Images blur past you as while you gain distance from " + n + ". You successfully made it to your last safe point");
                        Console.ReadKey();
                        // we want to go to store
                    }

                }

                else if (input.ToLower() == "h"|| input.ToLower() == "Heal")
                {
                    //heal - if you have a potion, a 50% chance to heal damage
                  if(Program.currentPlayer.potions == 0)
                    {
                        Console.WriteLine("You feel the ache in your wounds become unbearable. You reach for your side and grab a health potion, in its glisterning glory for Health.But when you bring it up, all there is, is an empty flask staring back at your desparate eyes.");

                        int damage = p - Program.currentPlayer.armorValue;

                        Console.WriteLine("The " + n + " continues its attack on you and lands a strike across your back. You lose " + damage + " health");

                        if (damage < 0)
                        {
                            damage = 0;
                        }
                        

                    }
                    else
                    {
                        Console.WriteLine("Arggh! You exclaim. Your wounds are in trouble and you realize that a health potion is the only way. You fumble around and stumble into the wall, dazed and afraid. When you feel around your waistlined bag, a source of hope grows in your eyes. A health potion, full and glittering in the dimly lit hallway stares back at you. Almost coddling your hope in this battle, you down the health potion. You start to feel a burning warmth enter your body while the exlir flows through your very soul.");

                        int basicPotion = 5;

                        Console.WriteLine("You heal " + basicPotion + " health");
                        Program.currentPlayer.health += basicPotion; 
                    }
                    Console.ReadKey();

                }

                Console.ReadKey(); // we want an input before determining another action in the while loop. 



            }
        }
    }
}
