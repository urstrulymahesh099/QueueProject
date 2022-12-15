using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace QueueProject
{
    internal class Queues//first in first out in data structure
    {
        Node rear;
        Node front;
        public void Enqueue(int data)//Enqueue adds an element to the end of the Queue.
        {
            Node node = new Node(data);
            if (front == null)
            {
                rear = node;
                front = rear;
            }
            else
            {
                rear.next = node;
                rear = rear.next;
            }
        }
        public void Display()
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Node temp = front;
            while (temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }
        }
        public void Dequeue()// removes the oldest element from the start of the Queue.
        {
            if (front == null)
            {
                Console.WriteLine("Queue is empty");
            }
            Console.WriteLine("{0} element dequeue ", front.data);
            front = front.next;
        }
    }
}