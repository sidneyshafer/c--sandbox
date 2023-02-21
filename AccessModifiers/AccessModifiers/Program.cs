using System;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            // ACCESS MODIFIERS
            /*  * Grant and prevent access
             *  * Marking fields and methods with access modifiers is part of the object
             *    oriented programming and increases the safeness of your code and are an
             *    important part of encapsulation (which is part of OOP)
             *  * In object oriented programming languages, encapsulation is used to refer
             *    to one of two related but distince notions, and sometimes to the combination
             *    thereof:
             *      * A language mechanism for restrciting direct access to some of the
             *        object's components.
             *      * A language construc that facilitates the bungling of data with the
             *        methods  (or other functions) operating on that data.
             *        
             *  * private = only accessible inside a class or struct
             *  
             *      private int age = 18;
             *      
             *      private void Walk()
             *      {
             *      }
             *     
             *     // age and Walk() are not accessible from another class
             *
             *  * public = accessible from everywhere in your project
             *  
             *      public int age = 18;
             *      
             *      public void Walk()
             *      {
             *      }
             *
             *  * protected = accessible from the class and all classes that derive from it
             *      
             *      protected int age = 18;
             *      
             *      protected void Walk()
             *      {
             *      }
             *
             *  * internal = accessible from its assembly (same project or namespace)
             *      
             *      internal int age = 18;
             *      
             *      internal void Walk()
             *      {
             *      }
             *
             *  * How?
             *      * As a rule of thumb, whenever you declare a new class, member or method
             *        I'd recommend initially going with the most restrictive access modifier
             *        that will allow your program to work (and then relaxing that as and 
             *        when necessary).
             *
             *  * Why? ---> gives you full control over your methods and variables.
            */
        }
    }
}
