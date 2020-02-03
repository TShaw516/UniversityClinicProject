using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Receptionist : Employee
    {
        //Properties
        public bool OnThePhone { get; set; }
      

        //Constructor
        public Receptionist() : base()
        { 
        }

        public Receptionist(string name, int iDNumber) : base(name, iDNumber)
        {
            Salary = 45000;
            Name = name;
            IDNumber = iDNumber;
            Paid = false;
            OnThePhone = false;
        }
        //Methods
        public override void DisplayInfo()
        {
            Console.WriteLine($"\n4. {Name} | ID Number:{IDNumber} | Salary: ${Salary}");
              
        
        }

        public void IsReceptionistOnPhone()
        {

            if (OnThePhone == true)
            {
                Console.WriteLine($"{Name} is on the phone");
            }
  
            else
            {
                Console.WriteLine("The Receptionist is not on the Phone");
            }
        }
         

        public override void PaySalary()
        {
            if (Paid == false)
            { Console.WriteLine($"Receptionist {Name} has been paid");
                Paid = true;
            }
            else
            { Console.WriteLine($"Receptionist {Name} has already been paid"); }
        }
    }
}
