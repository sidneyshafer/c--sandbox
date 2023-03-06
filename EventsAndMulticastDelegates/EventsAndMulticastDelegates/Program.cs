using System;

namespace EventsAndMulticastDelegates
{
    internal class Program
    {
        //Events vs Delegates
        // * Events are forced to behave like a list : += or -=
        // * Delegates allow a direct assignment : myDelegate = myMethod
        // * Events can't be triggered from outside the class that defines them.

        static void Main(string[] args)
        {
            //create an audio system
            AudioSystem audioSystem = new AudioSystem();
            //create a rendering engine
            RenderingEngine renderingEngine = new RenderingEngine();

            //create two players and give them Id's
            Player player1 = new Player("SteelCow");
            Player player2 = new Player("GoldenTurtle");
            Player player3 = new Player("DragonBoy");

            GameEventManager.TriggerGameStart();

            Console.WriteLine("Game is Running....Press any key to end the game.");
            //pause
            Console.Read();

            //trigger GameOver event
            GameEventManager.TriggerGameOver();

        }
    }
}