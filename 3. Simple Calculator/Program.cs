using System;
using System.Collections;
using System.Collections.Generic;

namespace _3._Simple_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var stack = new Stack<char>(input);
            int sum = 0;
            for (int i = 0; i < input.Length; i++)
            {
                char ch = input[i];
                if (ch == '+')
                {
                    sum += input[i + 1];
                }
                else if (ch == '-')
                {
                    sum -= input[i + 1];
                }
            }
            Console.WriteLine(sum);
        }
    }
}
