using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueues
{
    public class DequeOperation
    {
        public Node front, rear;
        public DequeOperation()
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
            else
            {
                //Add new node at the end of quque and change rear.
                this.rear.Next = temp;
                this.rear = temp;
            }
            Console.WriteLine("The Item inserted into Queue is {0}", key);
        }
        //Method to remove an key from queue.
        public void Dequeue()
        {
            //If queue is empty, return Null.
            if (this.front == null)
                Console.WriteLine("The Queue Is Empty");

            //Store privious front and move front one node ahead.
            Node temp = this.front;
            //Visit next node
            this.front = this.front.Next;

            //If front becomes null,then change rear also as null.
            if (this.front == null)
            {
                this.rear = null;
            }
            Console.WriteLine("Item deleted is{0}", temp.Key);
        }


    }
}
    