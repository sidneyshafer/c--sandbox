using System;
using System.Collections.Generic; 

namespace Queues
{
    class Program
    {
        static void Main(string[] args)
        {
            // Queues should be used when the order of data is important
            // used System.Collections.Generic;

            //define a queue of integers
            // can hold strings, objects, or any other data type
            Queue<int> queue = new Queue<int>();
            // add items -> adds to end of queue
            // the newest item will be the last item in the queue
            queue.Enqueue(1);
            queue.Enqueue(2);
            queue.Enqueue(3);
            // printing the element at the front of the queue
            Console.WriteLine("The top value is : {0}", queue.Peek()); // output -> 1

            // remove first item of queue
            int queueItem = queue.Dequeue();
            Console.WriteLine("Popped queue item is : {0}", queueItem);
            Console.WriteLine("The top value is now : {0}", queue.Peek());

            queue.Enqueue(4);
            queue.Enqueue(32);
            queue.Enqueue(45);
            queue.Enqueue(26);

            Console.WriteLine("");

            while (queue.Count > 0)
            {
                Console.WriteLine("Current queue count : {0}", queue.Count);
                Console.WriteLine("Front value {0} was removed from queue", queue.Dequeue());
                Console.WriteLine("Current queue count : {0}", queue.Count);
                Console.WriteLine("");
            }

            //Create queue of orders
            Queue<Order> ordersQueue = new Queue<Order>();
            
            //add orders from Branch1
            foreach(Order o in RecieveOrdersFromBranch1())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            //add orders from Branch2
            foreach (Order o in RecieveOrdersFromBranch2())
            {
                //add each order to the queue
                ordersQueue.Enqueue(o);
            }

            //as long as the queue is not empty
            while (ordersQueue.Count > 0)
            {
                //remove the order at the front of the queue
                //and store it in a variable called CurrentOrder
                Order currentOrder = ordersQueue.Dequeue();
                Console.WriteLine("Current Order ID : {0}\n" +
                    "Current Order Quantity : {1}", currentOrder.OrderId, currentOrder.OrderQuantity);
                //process the order
                currentOrder.ProcessOrder();
                Console.WriteLine("");
            }


            Console.ReadKey();
        }

        // Methods
        //this method will create an array of orders an return it
        static Order[] RecieveOrdersFromBranch1()
        {
            //creating new orders array
            Order[] orders = new Order[]
            {
                new Order(1,5),
                new Order(2,4),
                new Order(6,10)
            };
            return orders;
        }

        static Order[] RecieveOrdersFromBranch2()
        {
            //creating new orders array and initializing it with some objects of type Order
            Order[] orders = new Order[]
            {
                new Order(3,5),
                new Order(4,4),
                new Order(5,10)
            };
            // return the array of orders
            return orders;
        }
    }

    class Order
    {
        //order ID
        public int OrderId { get; set; }

        //quantity of the order
        public int OrderQuantity { get; set; }

        //simple constructor
        public Order(int id, int orderQuantity)
        {
            this.OrderId = id;
            this.OrderQuantity = orderQuantity;
        }

        //print message on the screen that the order was processed
        public void ProcessOrder()
        {
            //print message
            Console.WriteLine($"Order {OrderId} processed!");
        }
    }
}
