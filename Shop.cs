using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private Item[] _inventory;


        public Shop()
        {
            _gold = 0;
            _inventory = new Item[3];

        }

        public Shop(string Item)
        {
            string[] _inventory = new string[3] { "1. Bomb", "2. Mask", "3. Harp" };
            foreach (string i in _inventory)
            {
                Console.WriteLine(i);
            }
        }

        public bool sell(Player player, int inventory)
        {
            player.GetInventory();

            return true;

        }

    }

}
