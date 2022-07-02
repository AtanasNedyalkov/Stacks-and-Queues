using System;
using System.Collections.Generic;
using System.Linq;

namespace _4EX_Fast_Food
{
    class Program
    {
        static void Main(string[] args)


        {
            int quantityOfFood = int.Parse(Console.ReadLine());
            List<int> quantityOfOrder = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Queue<int> queue = new Queue<int>(quantityOfOrder);

            Console.WriteLine(queue.Max());
            int queueCount = queue.Count;
            for (int i = 1; i <= queueCount; i++)
            {
                if (quantityOfFood >= queue.Peek())
                {
                    quantityOfFood -= queue.Peek();
                    queue.Dequeue();
                }
                else
                {
                    break;
                }
            }
            if (queue.Count == 0)
            {
                Console.WriteLine("Orders complete");
            }
            else
            {
                Console.WriteLine("Orders left: "+string.Join(" ", queue));
            }
        }
    }
}
