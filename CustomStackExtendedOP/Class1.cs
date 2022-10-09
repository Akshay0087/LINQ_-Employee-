using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using customStack;
using Jedie;

namespace CustomStackExtendedOPNS
{
    public class customStackExtendedOP
    {
        public static void DisplayAllInternsNameAndId(CustomStack<Jedi> stack)
        {
            while (stack.Count > 0)
            {
                Console.WriteLine(stack.Pop().NameId);
            }
        }
    }
}
