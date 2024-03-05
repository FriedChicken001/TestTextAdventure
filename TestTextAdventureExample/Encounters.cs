using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTextAdventureExample
{
    public class Encoutners
    {
        static Random rand = new Random();
        //Encounters Generic - Generic coding for the encounters

        //Encounters - Scenarios
        public static void FirstEncounter() //voids do not return variables || This is the very first challenge the player will meet. Their "captor"
        {
            Console.WriteLine("You throw open the door and grab a rusty, metal sword while charging towards your captor");
            Console.WriteLine("He turns..");
            Console.ReadKey();
            Combat(false, "Human Rouge", 1, 4);
            // is not random encounter, name of enemy, power of enemy, health of enemy.
        } 

        public static void BasicFightEncounter()
        {
            Console.Clear();
            Console.WriteLine("...*drip*....");
            Console.ReadKey();
            Console.WriteLine("...*drip*....");
            Console.ReadKey();
            Console.WriteLine("...*drip*....");
            Console.ReadKey();
            Console.WriteLine("...*drip*....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You follow the wall. Damp, slightly moldy, and dimmly lit; the hallway seems to stretch endlessly through the dark...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(".......you keep moving, but you stop before turning a corner. Something within you is screaming that this isn't the way. But where else can you go. There's nothing behind you, but the only path you have left is forward.");
            Console.ReadKey();
            Console.Clear();
            Combat(true, "", 0, 0);

        } //randomized encocunters. these can be basic minions or Major Mini boss battles

        public static void WizardEncounter() //Mini boss. Can go into combat, cannot gain items. 
        {
            Console.Clear();
            Console.WriteLine("...Moving in a straight line... in what seems like forever, you find a door. Slightly ajar, with a hazy mist seeping out. The color reminds you of the Health Exilirs you have used in battle.");
            Console.ReadKey();
            Console.WriteLine("Your heart starts to beat faster. 'How do you I know this isn't a trap???' You mutter to yourself. The aches in your sides and the exhaustion in your bones urges you to venture through the door.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The more you inch closer, the more prominent a low, thunderous rumble can be felt. The hairs on your arms are starting to stand up, and your heart is beating even faster than before.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("*WHAM* The door flies wide open before you could approach it. The smoke falling and covering the floor of the hallway while a man walks out the room.");
            Console.ReadKey();
            Console.WriteLine("Upon closer inspection, this man isn't walking....... You stare as the end of the man's robe does not touch the ground. You begin to take in more information at an extreme rate");
            Console.ReadKey();
            Console.WriteLine("A Long Beard");
            Console.ReadKey();
            Console.WriteLine("Small Beady Eyes");
            Console.ReadKey();
            Console.WriteLine("A rotten, moldy staff");
            Console.ReadKey();
            Console.WriteLine("Mouth, agape showing nothing but a void");
            Console.ReadKey();
            Console.WriteLine("Nose bitten off due to the extreme rotten state of the body while his hands grips tightly to a large,pristine tome. ");
            Console.ReadKey();
            Combat(false, "Dark Wizard", 3, 10);
        }

        public static void TheDoorEncounter()
        {
            Console.WriteLine("...*pants*.....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...*pants*.......");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...*pants*............");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("...*pants*................");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Running...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("All you can do is run.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Your sides are aching. Hair plastered on your face from the sweat.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("The wind in your lungs, stabs you with every breath you take. The background blurs as you reach a room.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("A medium sized doorn greets in front of you. A single floating door, 2 inches off the ground.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You are beliwidered by the door as you try to catch your breath.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You straigten yourself up, and peek around the door.");
            Console.WriteLine("The door isn't connected to a wall and there's nothing behind it when you walk around it.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You appear near the front of the door and see that the handle is quite peculiar. A skull shaped konb pulses with a faint green light. Within the skull's voided eyes, a twinkle of a light is shown. You peer into them, an urge is starting to bubble from within you.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("As if on cue, the door *clicks* and opens itself.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Slowly opening.....");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("A hand, rotten and decayed, appears from the within.");
            Console.WriteLine("A sense of dread coddles you as you stand frozen in fear of what you are witnessing.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(".......'Gooo'......it whisphers, as the hand closes the door.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("Stumbling, you turn and run away from the door.");
            Console.ReadKey();
            Console.Clear();

        } //non-violent encounter. Does not lose health. Does not go into Combat. Does not gain any items


        public static void LevanderEncounter()
        {
            Console.Clear();
            Console.WriteLine("....'Is that...perfume?' you ask yourself as you round another corner. You find that the moldy, dirty hallway has transformed into a soft plush carpet under your feet. The light has dimmed and darken to a reddish color. Somewhat passionate. Somewhat exhilirating.");
            Console.ReadKey();
            Console.WriteLine("You begin to feel some relief. Although the scene itself is peculiar, you are just grateful to not feel the weight of immediate danger by your side.");
            Console.WriteLine("As you travel further through the passionate hallway, you find that you are smelling something....seductive..");
            Console.WriteLine("An alluring presence is making you walk down the hallway at a quickened pace. A presence lies ahead of you, beckoning you to them. In an excitement you turn the corner and you are greeted by a Large Pink monster.");
            Console.ReadKey();
            Console.WriteLine("Startled, you jump back. Although its a monster, it had an extremely volumpuous body. Pink fur on its hips, with a white accented, shallow waistline. Its long ears swayed in the air while it moved towards you.....its....frocklicking? ");
            Console.ReadKey();
            Console.WriteLine("'Don't be so shy now, I'm Levander. Come closer, I won't bite....for now c; '");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("Do you want to approach Levander?");
            Console.WriteLine("(Y)es or (N)o?");
            Console.ReadKey();

            string input = Console.ReadLine();

            // Player chooses here. Y == Heal N == Combat

            if (input.ToLower() == "y" || input.ToLower() == "yes")
            {
                Console.WriteLine("Someting about this creature is...intriguing. You ponder on their offer while you observe their behavior. This...creature, is slowly swaying its hips, shifting from left to right while maintaing its alluring gaze at you.");
                Console.ReadKey();
                Console.WriteLine("It chuckles. 'If you're going to do all that staring, you might as well come and get a closer look'.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("It winks at you and stretches out its paw. You think to yourself 'Out of everything you've done so far, this is by far the weirdest yet safest option you can get'.");
                Console.ReadKey();
                Console.WriteLine("You take its paw, and was lead gently deeper into the hallway. You take a turn and find yourself in front of a large woodern door.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("Levander chuckles as your eyes widen with curiosity. 'Welcome to my humble Abode', it says as it opens the door and reveals a lushious bed decorated with soft, plushy pillows and golden satin sheets.");
                Console.ReadKey();
                Console.WriteLine("You look around as it confuses you that such a room exists within a dangerous place. 'Go ahead and lay down, I'll take care of you for the rest of the night' Levander whisphers.");
                Console.ReadKey();
                Console.WriteLine("Almost, as if on cue, your body washes over with extreme exhaustion. You're unsure if you are truly safe in this place, you are just sure that you would rather be here, than outside that door....");

                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("As you fall asleep, you feel your body healing from the magical touch of Levander....");

                int kiss = rand.Next(5, 15);

                Console.WriteLine("You heal " + kiss + " health");

            }
            else
            {
                Combat(false, "Levander", 4, 15);
                // fight Levander
                Console.WriteLine("You begin to move away from this strange creature. This strange hallway, this strange experience.");
                Console.ReadLine ();
                Console.Clear();
                Console.WriteLine("'Get away from me. What even are you!'. You feel your heart accelerating as the hairs on the back of your neck begin to stand up. Everything in your body is saying that there's something wrong. Although you are unsure what that may be, you still begin to make distance between you and this creature.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("A frown begins to form on Levander's face. 'You know it's quite rude of you to reject a woman's request.' ");
                Console.ReadKey();
                Console.WriteLine("'Woman?!?!?!' You're a monster! Get away from me!' You scream as you turn to run...");
                Console.ReadKey();
                Console.WriteLine("But Levander's speed overcomes yours. It streches out its paws to reveal long sheathed claws with dragger like appearances.");
                Console.ReadKey();

                int damage = rand.Next(5, 15);

                Console.WriteLine("You were scratched and was dealt " +damage +" damage.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine("You scream in agony. You steady yourself against the wall and raise your weapon. ");
                Console.ReadKey();
                Console.WriteLine("If you're to make it out of this alive, you're going to have to face it head strong.");
            }
        } // choice based encounter. Can gain health, can go into combat


        //Encounter Tools - Helps with the encounters

        // Switches for different fights. Basic Minions for random encounters, Mini Boss Fights, Choice based fights.
        public static void RandomEncounter() // the randomizer for when the player will go into encoutners. 
        {
            switch(rand.Next(0, 3)) 
            {
                case 0:
                    BasicFightEncounter();
                    break;
                case 1:
                    WizardEncounter();
                    break;
                case 2:
                    LevanderEncounter();
                    break;
                case 3:
                    TheDoorEncounter();
                    break;

            }
        }
        public static void Combat(bool random, string name, int power, int health) //combat tools. Utility for making combat stat lines for encounters, mini bosses, etc. Does include the healing aspect as well. 
        {
            string n = ""; // name 
            int p = 0; // power
            int h = 0; // health
            if (random)
            {
                // this random generator is  to help randomize the encounters the player meets.
                n = GetName();
                p = Program.currentPlayer.GetPower();
                h = Program.currentPlayer.GetHealth();
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



                Console.WriteLine("========================");
                Console.WriteLine("| (A)ttack (D)efend    |");
                Console.WriteLine("| (R)un     (H)eal     |");
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
                        Shop.LoadShop(Program.currentPlayer);
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
                        Console.WriteLine("*Smack* While you were drinking the health potion, the " + n + " advanced and struck you.");

                        int damage = (p / 2) - Program.currentPlayer.armorValue;
                        if (damage < 0)
                        {
                            damage = 0;
                        }

                        Console.WriteLine("You lose " + damage + " health");
                            
                    }
                    Console.ReadKey();

                }

                if (Program.currentPlayer.health <=0) 
                {
                    //Death of the player Code
                    Console.WriteLine("*slash*.........");
                    Console.WriteLine("'IT.... HURTS....'the finals words you can muster through your teeth as you hold your wound open.\n" + n + " stands over you silently. Eyeing the last, pathetic moments of your life.");
                    Console.ReadKey();
                    Console.Clear();
                    //changed the color to keep the mood of dying. 
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WindowWidth = 60;
                    Console.WriteLine("YOU HAVE DIED");
                    Console.ReadKey();
                    System.Environment.Exit(0); // this ends the game. 
                }

                Console.ReadKey(); // we want an input before determining another action in the while loop. 



            }
            int c = rand.Next(10, 60);
            Console.WriteLine("As you stand victorious over the " + n + ", the body begins to dissolve and you start to see a slight shimmer. This shimmer begins to brighten as a small pile of gold materializes before you.\n...'Gold?' You say as you observe the golden coins in front of you.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine("You bend over and reach out to touch the mysterious reward. You confirm the reality you are in with the rough, slightly dirty texture of the gold coins in your hands. \nYou pick up the rest and put it in your pocket.\n You now have " + c + " gold coins." );


            Program.currentPlayer.coins += c; // this adds coins to the player tag.
            Console.ReadKey();
            Console.Clear();

        }
        public static string GetName() // The naming mechanic for the random minion fights that players can experience. 
        {
            switch(rand.Next(0, 10))
            {
                case 0:
                    return "Skeleton";
                case 1:
                    return "Wizard";
                case 2:
                    return "Wolf";
                case 3:
                    return "DireWolf";
                case 4:
                    return "Goblin";
                case 5:
                    return "Giant";
                case 6:
                    return "Death Knight";
                case 7:
                    return "Flameskull";
                case 8:
                    return "Ghastly";
                case 9:
                    return "Specter";
            }
            return "Human Fighter";

        }
    }
}
