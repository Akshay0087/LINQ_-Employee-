using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace customStack
{
    public class CustomStack <T>
    {
        public static T[] array = new T[10];

        public static int index=0;

        public CustomStack() { }

        public void Push(T a)
        {
            index++;
            array[index] = a;

        }
        public T Pop()
        {
            index--;
            
                var a = array[index + 1];
                return a;
            

        }

        public int Count()
        {
            return index+1;
        }

      
    }
}
