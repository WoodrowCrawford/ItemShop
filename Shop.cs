using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    class Shop
    {
        private int _gold;
        private item[] _inventory;
    }

    public Shop()
    {
        int gold = 0;
        string[] inventory = {"Bomb", "Mask", "Harp"};
        foreach(string i in inventory)
        {
            Console.WriteLine(i);
            
        }
        
        

    }

    public Shop(item[])
    {
        string inventory[];
    }

    public bool sell(Player player, int)
    {

    }
}
