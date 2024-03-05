using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestTextAdventureExample
{
    [Serializable]
    public class Player
    {
        Random rand; 

        public string name;
        public int id; //we'll use this to create unique ids for player saves
        public int coins = 30;
        public int health = 10;
        public int damage = 1;
        public int armorValue = 0;
        public int weaponValue = 1;
        public int potions = 5;


        public int mods = 0;

        public int GetHealth () // Modifier for the boss fights to increase power. 
        {
            int upper = (2 * mods + 7);
            int lower = (mods + 2);

            return rand.Next(lower, upper);

        }

        public int GetPower() // Modifier for the boss fights to increase power. 
        {
            int upper = (2 * mods + 2);
            int lower = (mods + 1);

            return rand.Next(lower, upper);

        }


    }
}
