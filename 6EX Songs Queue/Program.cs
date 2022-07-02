using System;
using System.Collections.Generic;

namespace _6EX_Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songsQueue = new Queue<string>(Console.ReadLine().Split(", "));
            while (songsQueue.Count>0)
            {
                string cmd = Console.ReadLine();
                //play
                if (cmd == "Play")
                {
                    songsQueue.Dequeue();
                }
                //Add {song}
                else if (cmd.Contains("Add"))
                {
                    string song = cmd.Split("Add ")[1];
                    if (songsQueue.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songsQueue.Enqueue(song);
                    }
                }
                //show
                else if (cmd == "Show")
                {
                    Console.WriteLine(string.Join(", ", songsQueue));
                }
            }
            Console.WriteLine("No more songs!");
        }
    }
}
