using System;
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
        private item[] _inventory;

    }



    public Player( int gold, int inventorySize)
    {
        gold = 40;
        int[] inventory = new int[3] { 1, 2, 3 };
        
        
        
        
    }

    public bool Buy(string shopIndex, int playerIndex)
    {
        Console.WriteLine(shopIndex, playerIndex);
        return true;
    }

    public void GetInventory()
    {
        
    }
}
