using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class Queue
    {
        public Node front, rear;
        public Queue()
        {
            this.front = this.rear = null;
        }
        //Method To add an Key To The Queue.
        public void Enqueue(int key)
        {
            //Create a new LL node.
            Node temp = new Node(key);

            //If queue is empty , then new node is front and rear both.
            if (this.rear == null)
            {

                this.front = this.rear = temp;
                return;

            }
            //Add new node at the end of quque andchange rear.
            this.rear.Next = temp;
            this.rear = temp;
            Console.WriteLine("The Item inserted into Queue is {0}", key);

        }


    }
}
  