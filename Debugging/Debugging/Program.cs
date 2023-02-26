using System;
using System.Collections.Generic;

namespace Debugging
{
    class Program
    {
        static void Main(string[] args)
        {
            // Add breakpoint in Visual Studio to debug (left side, grey bar)
            // Go to 'Degub' --> click 'Start Debugging'
            // Can step in, out, and go to next statement of program to see how the program runs
            var friends = new List<string> { "Sidney", "Allie", "Joe", "Frank", "Bob"};
            var partyFriends = GetPartyFriends(friends, 4);

            foreach (var name in friends)
                Console.WriteLine(name);

            Console.WriteLine();

            foreach (var name in partyFriends)
                Console.WriteLine(name);
        }

        public static List<string> GetPartyFriends(List<string> list, int count)
        {
            if (list == null)
                throw new ArgumentNullException("List", "List should not be empty.");

            if (count > list.Count || count <=0)
                throw new ArgumentOutOfRangeException("count", "Count cannot be greater then elements in list or less then zero.");

            var buffer = new List<string>(list);
            var partyFriends = new List<string>();

            while(partyFriends.Count < count)
            {
                var currentFriend = GetPartyFriend(buffer);
                partyFriends.Add(currentFriend);
                // should not remove item from list in memory
                // remove from the 'buffer', aka the copy of the friend list
                buffer.Remove(currentFriend);
            }
            return partyFriends;
        }


        /// <summary>
        /// This is the logic to figure out who is a party friend.
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public static string GetPartyFriend(List<string> list)
        {
            string shortestName = list[0];
            for(var i = 0; i < list.Count; i++)
            {
                if (list[i].Length < shortestName.Length)
                {
                    shortestName = list[i];
                }
            }
            return shortestName;
        }
    }
}
