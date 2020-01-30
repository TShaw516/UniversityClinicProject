using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Receptionist : Employee
    {
        //Properties
       

        //Constructor
        public Receptionist() : base()
        { 
        }

        public Receptionist(string name, int iDNumber) : base(name, iDNumber)
        {
            Salary = 45000;
            Name = "Jane";
            IDNumber = 444;
            Paid = false;
        }
        //Methods
        public void DisplayReceptionistInfo()
        {
            Receptionist newReceptionist = new Receptionist(Name, IDNumber);
            Console.WriteLine($"Receptionist:{newReceptionist.Name} ID Number:{newReceptionist.IDNumber} " +
                $"Salary: {newReceptionist.Salary} {newReceptionist.Paid}");
        
        }
    }
}
