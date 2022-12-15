using QueueProject;
using System.Collections.Generic;

using System;

namespace QueueProject
{
    public class Program
    {
        public static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("click below options:1.Queue");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Queues queues = new Queues();
                        queues.Enqueue(10);
                        queues.Enqueue(20);
                        queues.Enqueue(30);
                        queues.Dequeue();
                        queues.Display();
                        break;
                }
            }
        }
    }
}