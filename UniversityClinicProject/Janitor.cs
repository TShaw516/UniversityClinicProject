using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Janitor : Employee
    {
        //Properties

        //Constructor
        public Janitor() : base()
        { 
        
        }

        public Janitor(string name, int iDNumber) : base(name, iDNumber)
        {
            Salary = 40000;
            Name = "Neil";
            IDNumber = 333;
            Paid = false;
        
        }
        //Methods
        public void DisplayJanitorInfo()
        {
            Janitor newJanitor = new Janitor(Name, IDNumber);
            Console.WriteLine($"Janitor:{newJanitor.Name} ID Number:{newJanitor.IDNumber} Salary:${newJanitor.Salary} {newJanitor.Paid}");

        }
    }
}
