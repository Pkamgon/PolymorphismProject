using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismProject
{
    public class Program
    {
        static void Main(string[] args)
        {
          //Create an Employee object
           Employee employee = new Employee("Peter", "Paul");
            
           IQuittable quittableEmployee = employee;

           quittableEmployee.Quit();
        }
    }
}
