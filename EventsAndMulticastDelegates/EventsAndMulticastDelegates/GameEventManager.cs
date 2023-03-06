using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    internal class GameEventManager
    {
        //a new delegate type called GameEvent
        public delegate void GameEvent();

        //create two delegate variables called OnGameStart and OnGameOver
        public static event GameEvent OnGameStart, OnGameOver;

        //a static method to trigger OnGameStart
        public static void TriggerGameStart()
        {
            //check if the OnGameStart event is not empty,
            //meaning that other methods already subscribed
            if (OnGameStart != null)
            {
                //print simple message
                Console.WriteLine("The game has started....");
                //call the OnGameStart that will trigger all the methods subscribed to this event
                OnGameStart();
            }
        }

        //a static method to trigger OnGameOver
        public static void TriggerGameOver()
        {
            //check if the OnGameOver event is not empty,
            //meaning that other methods already subscribed
            if (OnGameOver != null)
            {
                //print simple message
                Console.WriteLine("Game Over....");
                //call the OnGameOver that will trigger all the methods subscribed to this event
                OnGameOver();
            }
        }
    }
}
