using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Employee
    {
        //Properties
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public virtual int Salary { get; set; }
        public bool Paid { get; set; }

        //Constructor
        public Employee()
        { 
        }

        public Employee(string name, int iDNumber)
        {
            Name = name;
            IDNumber = iDNumber;
        }
        
        public Employee(string name, int anIDNumber, int salary, bool paid)
        {
            Name = name;
            IDNumber = anIDNumber;
            Salary = salary;
            Paid = paid;
        }

        public Employee(string name, int anIDNumber, bool paid)
        {
            Name = name;
            IDNumber = anIDNumber;
            Paid = paid;
        }

        //Methods
        public void HasBeenPaid()
        {
            if (Paid == true)
            { Console.WriteLine("The Employee has been paid"); }
            else
            { Console.WriteLine("The Employee has not been paid"); }
        }
    }
}        
             

       



