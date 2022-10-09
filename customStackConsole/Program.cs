using customStack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Jedi;

namespace customStackConsole
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomStack<string> stack = new CustomStack<string>();
            stack.Push("Jedi-x");
            stack.Pop();
            stack.Push("Jedi");
            stack.Push("skillslab");

            while (stack.Count() > 0)
            {
                Console.WriteLine(stack.Pop());
            }

            Console.ReadLine();


            CustomStack<Jedi> stackJedi = new CustomStack<Jedi>();

            stackJedi.Push(new CustomStack<>)


        }
    }
}
