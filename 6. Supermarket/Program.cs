using System;
using System.Collections.Generic;

namespace _6._Supermarket
{
    class Program
    {
        static void Main(string[] args)
        {
            var queue = new Queue<string>();
            while (true)
            {
                string cmd = Console.ReadLine();
                //Paid --
                if (cmd == "Paid")
                {
                    foreach (var currentName in queue)
                    {
                        Console.WriteLine(currentName);
                    }
                    queue.Clear();
                }
                else if (cmd == "End")
                {
                    
                    Console.WriteLine($"{queue.Count} people remaining.");
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
