using System;
using System.Collections.Generic;
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
        private Player player = new Player();
        private Shop shop = new Shop();
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

       



        //Performed once when the game begins
        public void Start()
        {
           



            player.GetInventory();
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
