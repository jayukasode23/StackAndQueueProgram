using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class EmptyStack
    {
        LinkedList<int> list;

        public void CheckStack()
        {
            list = new LinkedList<int>();
        }
        public void Add(int n)
        {
            list.AddLast(n);
        }
        public void PeakPop()
        {
            foreach (int num in list.ToList())
            {
                Console.WriteLine("Remove Element " + num + "From Linked List");
                list.Remove(num);
            }
        }
    }
}
