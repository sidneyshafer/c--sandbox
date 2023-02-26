using System;

namespace DelegatesDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // DELEGATES
            /*
             * Example: private delegate void OnClickDelegate();
             * Let's say there is a button on a UI design named SendButton...
             * 
             * void SendButtonClick()
             * {
             *      Netowrk.Connect();
             *      Network.SendMessage();
             *      DisplayMessageSentDialog();
             * }
             * 
             * ****Refer to private delegate****
             * SendButton.OnClick = SendButtonClick;
             * 
             * ****Message box is show****
             * if(IsMouseHovering && IsLeftClickPressed)
             * {
             *      SEndButton.OnClick()
             * }
            */

            //list of names
            List<string> names = new List<string>() { "Sidney", "Allie", "Brent", "Lisa" };

            Console.WriteLine("----Before----");
            //print the names before the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            //calling RemoveAll and passing a method Filter we created
            names.RemoveAll(Filter);

            Console.WriteLine("----After----");
            //print the names after the remove all method
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }

            Console.ReadKey();

            //a method called Filter that takes a string
            static bool Filter(string s)
            {
                //return whether the string s contains the letter "i"
                //the contains method will return a bool which will return as well
                return s.Contains("i");
            }
        }
    }
}