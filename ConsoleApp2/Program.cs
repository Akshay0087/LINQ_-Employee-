using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;



namespace Day_3
{
    internal class Program
    {

        public class Employee : IEquatable<Employee>
        {
            public String name { get; set; }
            public int age { get; set; }
            public DateTime hireDate { get; set; }


            public int CompareTo(object obj)
            {
                return age.CompareTo((obj as Employee).age);
            }

            public bool Equals(Employee other)
            {
                return age == other.age && hireDate==other.hireDate && name==other.name;
            }

           // public bool operator ==(Employee x, Employee y) => x.Equals(y);
           // public bool operator !=(Employee x, Employee y) => !(x==y);

        }


        public class EmployeeComparer : IComparer<Employee>
        {
            public EmployeeComparer(CompareBY compareBY)
            {
                this._compareBY = compareBY;
            }

            public enum CompareBY
            {
                age,
                hireDate
            }

            CompareBY _compareBY;

            public int Compare(Employee x, Employee y)
            {
                if (_compareBY == CompareBY.age)
                    return x.age.CompareTo(y.age);



                return x.hireDate.CompareTo(y.hireDate);
            }
        }





        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>() {
            new Employee()
            {
                age = 25,
                hireDate = new DateTime(2022, 05, 01),
                name = "James"
            },



           new Employee()
            {
                age = 21,
                hireDate = new DateTime(2022, 05, 03),
                name = "new"
            },
                new Employee()
            {
                age = 9,
                hireDate = new DateTime(2022, 05, 03),
                name = "new"
            },
            new Employee()
            {
                age = 40,
                hireDate = new DateTime(2022, 05, 05),
                name = "Frank"
            },
            new Employee()
            {
                age = 40,
                hireDate = new DateTime(2023, 05, 05),
                name = "Frank"
            }};

            if (employees != null && employees.Count > 0)
            {

                //Return a List of employees that hired after the year 2005
                var employeeBefore2005 = employees.Where(z => z.hireDate > new DateTime(2005, 01, 01)).ToList();

                //Return a List of employees that hired after the year 2005
                var during2015 = employees.Any(z => z.hireDate > new DateTime(2015, 01, 01));

                //Find if all employees are above the age of 18 (should return a bool)
                var above18 = employees.All(z => z.age > 18);

                //Find and return the employee that has been in the company the longest
                var longest = employees.OrderBy(z => z.hireDate);

                //Get a List of employees ordered by Name then by HireDate, and return the first element (without using indexing)
                var first =employees.OrderBy(z => z.name).OrderBy(z=>z.hireDate).FirstOrDefault();

                //Return a List of the unique names of the employees
                var distint = employees.Distinct();

                //Return the first employee that is older than 50 years old, if none exist, return null
                var selectFirstEmployee = employees.Select(z => z.age>50).FirstOrDefault();

                //Validate that there is only one employee that has the name “Jane” and return the employee (one single Linq method)
                var singleEmployee = employees.SingleOrDefault(z => z.name.Equals("Jane"));

                Console.WriteLine("Here");

                Console.WriteLine(singleEmployee);
           
            }
            Console.ReadLine();



            //employees.Sort();
            //employees.Sort(new EmployeeComparer(EmployeeComparer.CompareBY.hireDate));

        }
    }
}