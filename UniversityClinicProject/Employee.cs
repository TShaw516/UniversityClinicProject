using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    class Employee
    {
        private string name;
        private string idNumber;
        private int salary;
        private bool paid;

        public void EmployeeName()
        {
            Console.WriteLine("Please Enter the Employee's Name: ");
            name = Console.ReadLine();
        }

        public void EmployeeID()
        {
            Console.WriteLine("Please Enter the Employee ID #: ");
            idNumber = Console.ReadLine();
        }

        public void EmployeeSalary()
        {
            Console.WriteLine("Please Enter the Employee Salary: ");
            salary = Convert.ToInt32(Console.ReadLine());
        }

        public void HasBeenPaid()
        {
            if (paid == true)
            { Console.WriteLine("The Employee has been paid"); }
            else
            { Console.WriteLine("The Employee has not been paid"); }
        }
    }
}        
             

       



