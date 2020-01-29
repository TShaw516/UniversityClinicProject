using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Janitor : Employee
    {
        //Properties
        public override int Salary { get; set; }

        //Constructor
        public Janitor() : base()
        { 
        
        }

        public Janitor(string name, int iDNumber, bool paid) : base(name, iDNumber, paid)
        {
            Salary = 40000;
        
        }
        //Methods
        public void DisplayJanitorInfo()
        {
            Janitor newJanitor = new Janitor("Neil", 333, true);
            Console.WriteLine($"Janitor:{newJanitor.Name} ID Number:{newJanitor.IDNumber} Salary:${newJanitor.Salary} {newJanitor.Paid}");

        }
    }
}
