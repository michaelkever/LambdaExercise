using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise
{
    public class Employee
    {
        public string fName { get; set; }
        public string lName { get; set; }
        public int iD { get; set; }
    }

    class Program
    {


        public static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>()
            {
                new Employee{fName = "Bob", lName = "Johnson", iD = 001},
                new Employee{fName = "Steve", lName = "Jackson", iD = 002},
                new Employee{fName = "Rob", lName = "Stevenson", iD = 003},
                new Employee{fName = "Linn", lName = "Byers", iD = 004},
                new Employee{fName = "Joe", lName = "Donaldson", iD = 005},
                new Employee{fName = "Michelle", lName = "Howard", iD = 006},
                new Employee{fName = "Vicky", lName = "Jordan", iD = 007},
                new Employee{fName = "Bob", lName = "Smith", iD = 008},
                new Employee{fName = "Joe", lName = "Jacobs", iD = 009},
                new Employee{fName = "Michael", lName = "Kever", iD = 010}
            };

            // foreach statement

            //List<Employee> Joe = new List<Employee>();
            //foreach(Employee name in employees)
            //{
            //    if (name.fName == "Joe")
            //    {
            //      Joe.Add(name);
            //      Console.WriteLine(name.fName + "" + name.lName);
            //    }

            //    Console.ReadLine();

            //}

            // Lambda Expressions

            List<Employee> joeName = employees.Where(x => x.fName == "Joe" ).ToList();
            foreach (Employee name in joeName)
            {
                Console.WriteLine(name.fName+ " " + name.lName);
            }
            

            List<Employee> joeNames = employees.Where(x => x.iD > 005).ToList(); ;
            
            foreach (Employee name in joeNames)
            {
                Console.WriteLine(name.fName + " " + name.lName + " Greater than Five ID.");
            }
            Console.ReadLine();



        } 
    }
}
