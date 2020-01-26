using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Employee
    {
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public int PaySalary { get; set; }
        public bool Paid { get; set; }

        public void HasBeenPaid()
        {
            if (Paid == true)
            { Console.WriteLine("The Employee has been paid"); }
            else
            { Console.WriteLine("The Employee has not been paid"); }
        }
    }
}        
             

       



