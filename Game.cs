using System;
using System.Collections.Generic;
using System.Text;

namespace HelloWorld
{
    struct item
    {
        public string itemName;
        public int cost;
    }


    class Game
    {

        //Calls on created variables
        private bool _gameover = false;
        private Player player = new Player();
        private Shop _Shop;
        private item _bomb;
        private item _mask;
        private item _harp;


       
        //Run the game
        public void Run()
        {
            Start();

            while(_gameover == false)
            {
                Update();
            }

            End();

        }

        //Names the items
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
            Console.WriteLine("Welcome!");
        }

        //Repeated until the game ends
        public void Update()
        {
            
        }

        //Performed once when the game ends
        public void End()
        {
            
        }
    }
}
