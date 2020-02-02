using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Receptionist : Employee
    {
        //Properties
       // public bool OnThePhone { get; set; }
       // private bool onThePhone;

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
        }
        //Methods
        public override void DisplayInfo(int counter)
        {
            Console.WriteLine($"\n4. {Name} ID Number:{IDNumber} Salary: {Salary}");
              
        
        }
        /* public void IsReceptionistOnPhone()
         {
             onThePhone = true;
             if (onThePhone)
             {
                 Console.WriteLine("On the phone");
             }
             else 
             {
                 Console.WriteLine("Not on the phone");
             }
         */

        public override void PaySalary(Doctor myDoctor)
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
