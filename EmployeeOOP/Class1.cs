using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeOOP
{
    public class Employee :IComparable
    {
        public string name { get; set; }
        public int age { get; set; }
        public DateTime hireDate { get; set; }


        public int CompareTo(object obj)
        {
            return age.CompareTo((obj as Employee).age);
        }

       
    }
}
