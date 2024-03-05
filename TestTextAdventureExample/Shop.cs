using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTextAdventureExample
{
    public class Shop
    {

        public static void LoadShop(Player p)
        {

            RunShop(p);

        }

        public static void RunShop(Player p)
        {
            int potionP;
            int armorP;
            int weaponP;
            int difP;

            while (true)
            {
                potionP = 25 + 10 * p.mods;
                armorP = 100 * p.armorValue;
                weaponP = 100 * (p.weaponValue + 1);
                difP = 300 + 100 *p.mods;



                Console.Clear();
                Console.WriteLine("=============================");
                Console.WriteLine("| Welcome to the Shop!      |");
                Console.WriteLine("| (P)otion: $" +potionP+   "|");
                Console.WriteLine("| (A)rmor: $"+armorP+      "|");
                Console.WriteLine("| (W)eapon:$"+weaponP+     "|");
                Console.WriteLine("| (D)ifficulty Mod:$"+difP+"|");
                Console.WriteLine("-----------------------------");
                Console.WriteLine("|         (E)xit            |");
                Console.WriteLine(""); // blank line for separation
                Console.WriteLine(""); // blank line for separation
                Console.WriteLine("=========================================");// player stats for educated purchases
                Console.WriteLine("|             "+p.name+"'s Stats        |");
                Console.WriteLine("| Current Health: " + p.health +       "|");
                Console.WriteLine("| Coins: " + p.coins +                 "|");
                Console.WriteLine("| Weapon Strength: " + p.weaponValue + "|");
                Console.WriteLine("| Armor Class: " + p.armorValue +      "|");
                Console.WriteLine("| Potions: " +p.potions +              "|");
                Console.WriteLine("| Difficulty Mod: " +p.mods+           "|");
                Console.WriteLine("----------------------------------------");

                //wait for player input

                string input = Console.ReadLine().ToLower();

                if (input == "p" || input == "potion")
                {
                    TryBuy("potion", potionP, p);

                }
                else if (input == "a" || input == "armor")
                {
                    TryBuy("armor", armorP, p);

                }
                else if (input == "w" || input == "weaponr")
                {
                    TryBuy("weapon", weaponP, p);
                }
                else if (input == "d" || input == "difficulty mod")
                {
                    TryBuy("difficulty mod", difP, p);
                }
                else if (input == "e" || input == "exit")
                    break;
            }


            
        }
        static void TryBuy(string item, int cost, Player p)
        {
            if(p.coins >= cost)
            {
                if (item == "potion")
                    p.potions++;
                else if(item == "weapon")
                    p.weaponValue++;
                else if (item == "armor")
                    p.armorValue++;
                else if (item == "dif")
                    p.mods++;

                p.coins -= cost;
            }
            else
            {
                Console.WriteLine("Your pockets feel light. This probably isn't the best time to spend gold.");
                Console.ReadLine();

            }
        }
        
    }
}
