﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;
using System.Runtime.CompilerServices;
using System.Text;

namespace HelloWorld
{
    class Player
    {
        private int _gold;
        private Item[] _inventory;





        public Player()
        {
            _gold = 40;
            _inventory = new Item[3];

        }


        
        public bool Buy(Item item, int inventorySpace)
        {
            if(_gold >= item.cost)
            {
                _gold -= item.cost;
                _inventory[inventorySpace] = item;
                return true;
            }
            return false;
        }


        public Item[] GetInventory()
        {
            return _inventory;
        }

        public int GetGold()
        {
            return _gold;
        }
    }
}