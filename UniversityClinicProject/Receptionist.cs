using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Receptionist : Employee
    {
        //Properties
        public override int Salary { get; set; }
        

        //Constructor
        public Receptionist() : base()
        { 
        }

        public Receptionist(string name, int iDNumber, bool paid) : base(name, iDNumber, paid)
        {
            Salary = 45000;
            Name = "Jane";
            IDNumber = 444;
        }
        //Methods
        public void DisplayReceptionistInfo()
        {
            Receptionist newReceptionist = new Receptionist(Name, IDNumber, true);
            Console.WriteLine($"Receptionist:{newReceptionist.Name} ID Number:{newReceptionist.IDNumber} " +
                $"Salary: {newReceptionist.Salary} {newReceptionist.Paid}");
        
        }
    }
}
