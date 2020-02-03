using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Employee
    {
        Hospital theHospital = new Hospital();

        //Properties
        public string Name { get; set; }
        public int IDNumber { get; set; }
        public virtual int Salary { get; set; }
        public bool Paid { get; set; }

        //Constructors
        public Employee()
        {
        }

        public Employee(string name, int iDNumber)
        {
            Name = name;
            IDNumber = iDNumber;
        }

        //Methods
        public void MainMenu()
        {
            Console.WriteLine("Main Menu:");
            Console.WriteLine("1- Show List of All Employees");
            Console.WriteLine("2- Show Medical Employee List");
            Console.WriteLine("3- Show Regular Employee List");
            Console.WriteLine("4- Exit Application");
            Console.WriteLine("Select a number to perform an action");
           
        }



        public void MedicalEmployeeMenu()
        {
            Console.WriteLine("1- Draw Blood");
            Console.WriteLine("2- Care for Patient");
            Console.WriteLine("3- Pay the Employee");
        }

        public void RegularEmployeeMenu()
        {
            Console.WriteLine("1- Check if the Janitor is Sweeping");
            Console.WriteLine("2- Check if Receptionist is on the Phone");
            Console.WriteLine("3- Pay the selected Employee");
        }

        public void HasBeenPaid()
        {
            if (Paid == true)
            { Console.WriteLine("The Employee has been paid"); }
            else
            { Console.WriteLine("The Employee has not been paid"); }
        }

        public virtual void DisplayInfo()
        { 
        
        }
    
        public virtual void DrawBlood(Patient newPatient)
        {
            


        }

        public virtual void CareForPatient(Patient newPatient)
        { 
        
        }

        public virtual void PaySalary()
        { 
        
        }

        
      
    }
}        
             

       



