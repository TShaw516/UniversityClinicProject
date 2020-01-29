using System;

namespace UniversityClinicProject
{
    class Program
    {
        static void Main(string[] args)
        {
            //new objects/classes
            Employee newEmployee = new Employee();
            
            Nurse newNurse = new Nurse();
            Receptionist newReceptionist = new Receptionist();
            Janitor newJanitor = new Janitor();
            Patient newPatient = new Patient();
            Doctor newDoctor = new Doctor();
             
            bool inHospital = true; //stays in menu till exit 'bool is false'
            string menuChoice = "";//Variable that saves user's choice

            //loop for list of employees
            while (inHospital)
            {
                Console.WriteLine("University Clinic Hospital:");
                Console.WriteLine("\nEmployee List:  ");
                Console.WriteLine("\n1. Doctor Turk");
                Console.WriteLine("2. Nurse Carla");
                Console.WriteLine("3. Janitor Neil");
                Console.WriteLine("4. Receptionist Tatyana");
                Console.WriteLine("5. Exit");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        newDoctor.DisplayDoctorsInfo();
                        break;

                    case "2":
                        break;

                    case "3":
                        break;

                    case "4":
                        break;

                    case "5":
                        inHospital = false;
                        break;


                }

            }

            Employee FirstEmployee = new Employee("Turk", 321);
            Console.WriteLine($"{FirstEmployee.Name} {FirstEmployee.IDNumber}");

            Employee SecondEmployee = new Employee();
            Console.WriteLine($"{SecondEmployee.Name} {SecondEmployee.IDNumber}");

            SecondEmployee.Name = "Jim";
            Console.WriteLine($"{SecondEmployee.Name} {SecondEmployee.IDNumber}");

            SecondEmployee.IDNumber = 2232;
            SecondEmployee.Salary = 50000;
            Console.WriteLine($"{SecondEmployee.Name} {SecondEmployee.IDNumber} {SecondEmployee.Salary}");

            Employee ThirdEmployee = new Employee("Larry", 595959, 30000, true);
            Console.WriteLine($"{ThirdEmployee.Name}, {ThirdEmployee.IDNumber}, {ThirdEmployee.Salary}, {ThirdEmployee.Paid}" );

            //(string name, int iDNumber, int salary, bool paid, string specialty)
           

            Doctor secondDoctor = new Doctor();
            secondDoctor.Name = "Dr. Phil";
            Console.WriteLine(secondDoctor.Name);

          
        }
    }
}
