﻿using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Employee
    {
        //Create a new List
        public List<Employee> employeeList = new List<Employee>();

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
        public void HasBeenPaid()
        {
            if (Paid == true)
            { Console.WriteLine("The Employee has been paid"); }
            else
            { Console.WriteLine("The Employee has not been paid"); }
        }

        public void DisplayEmployees()
        {
            Console.WriteLine("\nClick on an employee to find out more..\n");

            int counter = 1;

            foreach (Employee employee in employeeList)
            {

                employee.DisplayInfo();
                counter++;
            }
            
        }

        
      public void ShowEmployeeInfo()
        {
            string actionMenu = "";
            bool choosingAction = true;
            while (choosingAction)
            {
                int employeeChoice = Convert.ToInt32(Console.ReadLine());
                Employee chosenEmployee = employeeList[employeeChoice - 1];
            }
        }

        public virtual void DisplayInfo()
        { 
        
        }
    
        public virtual void DrawBlood()
        { 
        
        }

        public virtual void CareForPatient()
        { 
        
        }

        public virtual void PaySalary()
        { 
        
        }

        
      
    }
}        
             

       



