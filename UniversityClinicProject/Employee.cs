using System;
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

        public void DisplayEmployees()
        {
            Console.WriteLine("\nClick on an employee to find out more..\n");

            foreach (Employee employees in employeeList)
            {
                employees.DisplayInfo();
             
            }

        }

        public void SelectEmployee()
        {
            //user inserts chosen employee that corresponds to list index
            int employeeChoice = Convert.ToInt32(Console.ReadLine());
            Employee chosenEmployee = employeeList[employeeChoice - 1];
            Console.Clear();

            //menu to choose task for employee
            Console.WriteLine("What do you want your employee to do?");
            Console.WriteLine("1. Draw Blood");
            Console.WriteLine("2. Care For Patient");
            Console.WriteLine("3. Pay Employee");
            Console.WriteLine("4. Exit");
           string taskChoice = Console.ReadLine();

            switch (taskChoice)
            {
                case "1":
                    DrawBlood();
                   
                    break;

                case "2":
                    CareForPatient();
                    break;

                case "3":
                    PaySalary();
                    break;

                case "4":
                    Console.Clear();
                    break;

            }

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
             

       



