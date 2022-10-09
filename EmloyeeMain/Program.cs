using EmployeeOOP;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmloyeeMain
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() {
                new Employee()
                {
                    age=25,
                    name="James",
                    hireDate=new DateTime(2022,05,01)
                },
                new Employee()
                {
                    age=21,
                    name="Jane",
                    hireDate=new DateTime(2022,05,03)
                },
                new Employee()
                {
                    age=40,
                    name="Frank",
                    hireDate=new DateTime(2022,05,05)
                }
            };


            employees.Sort(new EmployeeComparer());
            Console.WriteLine(employees[0].name);
            Console.ReadLine();
     
        }
    }
    

    public class EmployeeComparer : IComparer<Employee> { 

        public EmployeeComparer(CompareBy compareBy)
        {
            _compareBy = compareBy;
        }
    
        enum CompareBy
        {
            age,hireDate
        }

        CompareBy _compareBy;
        
        public int Compare(Employee x, Employee y)
        {
            if(_compareBy==CompareBy.age)
                return x.age.CompareTo(y.age);
            return x.hireDate.CompareTo(y.hireDate);
        }
    }
}