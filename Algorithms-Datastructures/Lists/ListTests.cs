using System;

namespace Algorithms_Datastructures.Lists
{
    public class ListTests
    {
        public ListTests()
        {
            Random rng = new Random();
            
            Console.WriteLine("::Queue Test::");
            Queue<int> q = new Queue<int>();
            for (int i = 0; i < 10; i++)
            {
                q.Enqueue(rng.Next(0, 100));
            }
            q.Dequeue();
            q.Enqueue(rng.Next(0, 100));
            q.Enqueue(rng.Next(0, 100));
            q.Dequeue();
            q.Dequeue();
            q.Dequeue();
            q.Enqueue(rng.Next(0, 100));
            q.Enqueue(rng.Next(0, 100));
            q.Dequeue();
            q.Enqueue(rng.Next(0, 100));
            q.Enqueue(rng.Next(0, 100));
            Console.WriteLine("[{0}]", string.Join(", ", q.getQueue()));
            Console.WriteLine("[{0}]", string.Join(", ", q));
        }
    }
}