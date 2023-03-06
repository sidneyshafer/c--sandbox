using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    //Player Class
    internal class Player
    {
        //Player name
        public string PlayerName { get; set; }

        //simple constructor
        public Player(string name)
        {
            this.PlayerName = name;
            //subscribe to the OnGameStart and OnGameOver events
            // += means to subscribe --> can only "subscribe" to events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game, spawn the player
        private void StartGame()
        {
            Console.WriteLine($"Spawning Player with ID : {PlayerName}");
        }

        //when the game is over, remove the player from the game
        private void GameOver()
        {
            Console.WriteLine($"Removing Player with ID : {PlayerName}");
        }

    }
}
