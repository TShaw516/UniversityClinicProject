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
            Console.WriteLine("1- Show Medical Employee List");
            Console.WriteLine("2- Show Regular Employee List");
            Console.WriteLine("3- Exit Application");
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
            Console.WriteLine("1- Sweep");
            Console.WriteLine("2- Start Phone Calls");
            Console.WriteLine("3- Pay the Employee");
        }

        /*public void DisplayEmployees()
        {
            Console.WriteLine("\nClick on an employee to find out more..\n");
            int counter = 1;
            foreach (Employee employees in employeeList)
            {
                employees.DisplayInfo();
                counter++;  
            } 
        }

        public void SelectEmployee(Patient newPatient)
        {
            Doctor myDoctor = new Doctor();
            Nurse myNurse = new Nurse();

            //user inserts chosen employee that corresponds to list index
            int employeeChoice = Convert.ToInt32(Console.ReadLine());
            Employee chosenEmployee = employeeList[employeeChoice - 1];
            Console.Clear();

            if (chosenEmployee == employeeList[0])
            {
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
                        myDoctor.DrawBlood(newPatient);
                        break;
                    case "2":
                        myDoctor.CareForPatient(newPatient);
                        break;
                    case "3":
                        PaySalary(myDoctor);
                        break;
                    case "4":
                        Console.Clear();
                        break;
                }
            }
            else
                    {
                Console.WriteLine($"Employee can't draw blood.  Only Medical Profesionals");
                     }
        }
        */

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
             

       



