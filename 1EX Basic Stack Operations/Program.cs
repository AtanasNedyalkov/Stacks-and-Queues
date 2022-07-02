using System;
using System.Linq;
using System.Collections.Generic;
using System.Collections;

namespace _1EX_Basic_Stack_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers1 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int n = numbers1[0];//push to stack
            int s = numbers1[1];//pop to stack
            int x = numbers1[2];//contains to stack
            Stack <int> stack = new Stack<int>();
            int[] numbers2 = Console.ReadLine().Split().Select(int.Parse).ToArray();
            for (int i = 0; i < n; i++)
            {
                stack.Push(numbers2[i]);
            }
            for (int i = 0; i < s; i++)
            {
                stack.Pop();
            }
            if (stack.Count == 0)
            {
                Console.WriteLine(0);
            }
            else if (stack.Contains(x))
            {
                Console.WriteLine("true");
            }
            else 
            {
                Console.WriteLine(stack.Min());
            }
        }
    }
}
