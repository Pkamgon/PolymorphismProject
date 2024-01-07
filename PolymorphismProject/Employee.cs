using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace PolymorphismProject
{
    class Employee : IQuittable
    {
        public string FirstName { get; set;}
        public string LastName { get; set; }

        internal Employee(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void Quit()
        {

            Console.WriteLine("Employee Quit");
            Console.ReadLine();
        }
    }      
}
