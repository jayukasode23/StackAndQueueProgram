using StackAndQueues;

public class Program
{
    public static void Main(string[] args)
    {
        CreateStack objStack = new CreateStack();
        objStack.Push(70);
        objStack.Push(30);
        objStack.Push(56);
        objStack.Display();

        EmptyStack stack = new EmptyStack();
        stack.CheckStack();
        stack.Add(70);
        stack.Add(30);
        stack.Add(56);
        stack.PeakPop();

        Queue queue = new Queue();
        queue.Enqueue(56);
        queue.Enqueue(30);
        queue.Enqueue(70);
        Console.WriteLine("Queue Front" + queue.front.Key);
        Console.WriteLine("Queue Rear" + queue.rear.Key);

        DequeOperation queues = new DequeOperation();
        queues.Enqueue(56);
        queues.Enqueue(30);
        queues.Enqueue(70);
        Console.WriteLine("Queue Front" + queues.front.Key);
        Console.WriteLine("Queue Rear" + queues.rear.Key);

        Console.WriteLine("Dequeue");
        queues.Dequeue();
        queues.Dequeue();
        queues.Dequeue();

    }
}
