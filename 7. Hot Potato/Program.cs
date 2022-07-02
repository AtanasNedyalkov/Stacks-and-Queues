using System;
using System.Collections.Generic;

namespace _7._Hot_Potato
{
    class Program
    {
        static void Main(string[] args)
        {
            var players = Console.ReadLine().Split();
            var n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>(players);
            while (queue.Count>1)
            {
                for (int i = 1; i < n; i++)
                {
                    var player = queue.Dequeue();
                    queue.Enqueue(player);
                }
                var lostPLayer = queue.Dequeue();
                Console.WriteLine($"Removed {lostPLayer}");
            }
            var lastPlayer = queue.Dequeue();
            Console.WriteLine($"Last is {lastPlayer}");
        }
    }
}
