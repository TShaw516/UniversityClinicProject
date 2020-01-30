using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Receptionist : Employee
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
        public void DisplayReceptionistInfo()
        {
            Receptionist newReceptionist = new Receptionist(Name, IDNumber);
            Console.WriteLine($"Receptionist:{newReceptionist.Name} ID Number:{newReceptionist.IDNumber} " +
                $"Salary: {newReceptionist.Salary} {newReceptionist.Paid}");
        
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
    }
}
