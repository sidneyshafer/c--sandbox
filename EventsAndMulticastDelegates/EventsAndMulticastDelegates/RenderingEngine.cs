﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventsAndMulticastDelegates
{
    //RenderingEngine Class
    internal class RenderingEngine
    {
        //simple constructor
        public RenderingEngine()
        {
            //subscribe to the OnGameStart and OnGameOver events
            GameEventManager.OnGameStart += StartGame;
            GameEventManager.OnGameOver += GameOver;
        }

        //at the start of the game, we want to enable the rendering engine
        //and start the visual
        private void StartGame()
        {
            Console.WriteLine("Rendering Engine Started...");
            Console.WriteLine("Drawing Visuals.....");
        }

        //when the game is over, we want to stop our rendering engine
        private void GameOver()
        {
            Console.WriteLine("Rendering Engine Stopped...");
        }
    }
}
