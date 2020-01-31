using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Janitor : Employee
    {
        //Properties

        //Constructor
        public Janitor() : base()
        { 
        
        }

        public Janitor(string name, int iDNumber) : base(name, iDNumber)
        {
            Salary = 40000;
            Name = name;
            IDNumber = iDNumber;
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
