﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    //AudioSystem Class
    internal class AudioSystem
    {
        //simple constructor
        public AudioSystem()
        {
            //subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game,
        //we want to enable the audio system and start playing audio clips
        private void StartGame()
        {
            Console.WriteLine("Audo System Started...");
            Console.WriteLine("Playing Audio.....");
        }

        //when the game is over,
        //we want to stop the audio system
        private void GameOver()
        {
            Console.WriteLine("Audio System Stopped...");
        }
    }
}
