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
        public override void DisplayInfo(int counter)
        {
            Console.WriteLine($"\n3. {Name} ID Number:{IDNumber} Salary:${Salary}");
        }

        public override void PaySalary(Doctor myDoctor)
        {
            if (Paid == false)
            { Console.WriteLine($"Janitor {Name} has been paid");
                Paid = true;
            }
            else
            { Console.WriteLine($"Janitor {Name} has already been paid"); }
        }
    }
}
