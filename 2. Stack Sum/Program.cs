using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace _2._Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var
                input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var stack = new Stack<int>(input);
            var command = Console.ReadLine().ToLower();
            while (true)
            {
                var tokens = command.Split();
                if (tokens[0] == "add")
                {
                    int n1 = int.Parse(tokens[1]);
                    int n2 = int.Parse(tokens[2]);
                    stack.Push(n1);
                    stack.Push(n2);
                }
                else if (tokens[0] == "remove")
                {
                    int count = int.Parse(tokens[1]);
                    if (stack.Count >= count)
                    {
                        for (int i = 0; i < count; i++)
                        {
                            stack.Pop();
                        }
                    }
                }
                else if (tokens[0] == "end")
                {
                    var sum = stack.Sum();
                    Console.WriteLine($"Sum: {sum}");
                    break;
                }
                command = Console.ReadLine().ToLower();
            }
        }
    }
}
