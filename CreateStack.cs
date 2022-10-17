using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StackAndQueues
{
    public class CreateStack
    {
        internal Node Head;

        public CreateStack()
        {
            this.Head = null;
        }
        public void Push(int Value)
        {
            Node NewNode = new Node(Value);
            if (this.Head == null)
            {
                NewNode.Next = null;
            }
            else
            {
                NewNode.Next = Head;
            }
            this.Head = NewNode;
            Console.WriteLine("{0} is Added To The Stack ", NewNode.Key);
        }
        public void Display()
        {
            if (this.Head == null)
            {
                Console.WriteLine("Stack Is Empty");
            }
            Console.WriteLine("The Stack is :");
            Console.WriteLine("Head:");
            Node Tempnode = this.Head;

            while (Tempnode != null)
            {
                Console.WriteLine(Tempnode.Key + " ");
                Tempnode = Tempnode.Next;
            }
        }

    }
}
