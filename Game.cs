using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace HelloWorld
{
    struct Item
    {
        public string itemName;
        public int cost;
    }


    class Game
    {

        //Calls on created variables
        private bool _gameover = false;
        private Player _player;
        private Shop _shop;
        private Item[] _shopInventory;
        private Item _bomb;
        private Item _mask;
        private Item _harp;



        //Run the game
        public void Run()
        {
            Start();

            while (_gameover == false)
            {
                Update();
            }

            End();

        }

        //Names the items for the shop
        public void NameItems()
        {
            _bomb.itemName = "Bomb";
            _bomb.cost = 10;
            _mask.itemName = "Mask";
            _mask.cost = 10;
            _harp.itemName = "Harp";
            _harp.cost = 10;


        }

        public void PrintInventory(Item[] inventory)
        {
            for(int i = 0; i < inventory.Length; i++)
            {
                Console.WriteLine((i + 1) + ". " + inventory[i].itemName + inventory[i].cost);
                _shopInventory = inventory;
            }
        }
       
        public void OpenShopMenu()
        {
            Console.WriteLine("Welcome! PLease select an item.");
            PrintInventory(_shopInventory);

            char input = Console.ReadKey().KeyChar;

            int itemIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        itemIndex = 0;
                        break;
                    }
                case '2':
                    {
                        itemIndex = 1;
                        break;
                    }
                case '3':
                    {
                        itemIndex = 2;
                        break;
                    }
                default:
                    {
                        return;
                    }
            }
            if(_player.GetGold() < _shopInventory[itemIndex].cost)
            {
                Console.WriteLine("Yo you broke broke man!! LOL");
                return;
            }

            Console.WriteLine("Choose a slot to replace.");
            PrintInventory(_player.GetInventory());
            input = Console.ReadKey().KeyChar;

            int playerIndex = -1;
            switch (input)
            {
                case '1':
                    {
                        playerIndex = 0;
                        break;
                    }
                case '2':
                    {
                        break;
                    }
            }
        }


        //Performed once when the game begins
        public void Start()
        {
           



          ;
            Console.WriteLine("Welcome!");
            Console.WriteLine("Please pick an item to buy!");
            
        }

        //Repeated until the game ends
        public void Update()
        {
             
        }

        //Performed once when the game ends
        public void End()
        {
            Console.WriteLine("Thank you! Please come again!");
        }
    }
}
