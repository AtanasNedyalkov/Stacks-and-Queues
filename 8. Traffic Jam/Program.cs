using System;
using System.Collections.Generic;
using System.Linq;

namespace _8._Traffic_Jam
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            var queue = new Queue<string>();
            var totalCarPassed = 0;
            while (true)
            {
                string cmd = Console.ReadLine();
                if (cmd == "green")//n cars passed ahead
                {
                    for (int i = 0; i < n; i++)
                    {
                        if (queue.Count>0)
                        {
                            var car = queue.Dequeue();
                            Console.WriteLine($"{car} passed!");
                            totalCarPassed++;
                        }
                    }
                }
                else if (cmd == "end")//print how many cars passed in total
                {
                    Console.WriteLine($"{totalCarPassed} cars passed the crossroads.");
                    break;
                }
                else
                {
                    queue.Enqueue(cmd);
                }
            }

        }
    }
}
