using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Janitor : Employee
    {
        //Properties
        public bool Sweeping { get; set; }

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
            Sweeping = true;
        
        }
        //Methods
        public override void DisplayInfo()
        {
            Console.WriteLine($"\n3. {Name} | ID Number:{IDNumber} | Salary: ${Salary}");
        }

        public override void PaySalary()
        {
            if (Paid == false)
            { Console.WriteLine($"Janitor {Name} has been paid");
                Paid = true;
            }
            else
            { Console.WriteLine($"Janitor {Name} has already been paid"); }
        }

        public void BeginSweeping()
        {
            
            if (Sweeping == true)
            {
                Console.WriteLine($"{Name} is sweeping");
              
            }
            else
            {
                Console.WriteLine($"{Name} is not sweeping");
            }
        }
    }
}
