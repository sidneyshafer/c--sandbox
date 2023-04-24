using System;

namespace GarbageCollectorC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // C# Garbage Collection
            /*
             * The .NET Framework provides an automatic memory management
             * Which means you do not have to use the garbage collector manually
             * It is done automatically in C#
             * Example:
             *  Human sidney = new Human() --> allocates Memory
             * The framework takes care of reclaiming memory for reuse in the system,
             * once objecs are no longer being used
            */

            // What you need to know about C# Garbage Collection
            /*
             * You don't have to manually call the garbage collector (but you can)
             * The garbase collector requires processing power
             * It's goal is to free up memory but not use too much processing power
             * Memory isn't necessarily relaimed right away
             * You can implement a 'finalizer' method to execute code just before an object
             * is released from memory by the GC.
            */

            // When does the Garbage Collector (GC) run?
            /*
             * When the system has low physical memory
             * When the memory allocated exceeds a pre-set threshold
             * When GC.Collect() is called --> this is a tricky method
            */
        }
    }
}