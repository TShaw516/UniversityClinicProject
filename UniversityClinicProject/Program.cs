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
                Console.WriteLine("4. Receptionist Jane");
                Console.WriteLine("5. Exit");
                menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        newDoctor.DisplayDoctorsInfo();
                        break;

                    case "2":
                        newNurse.DisplayNurseInfo();
                        break;

                    case "3":
                        newJanitor.DisplayJanitorInfo();
                        break;

                    case "4":
                        newReceptionist.DisplayReceptionistInfo();
                        break;

                    case "5":
                        inHospital = false;
                        break;


                }

            }
        }
    }
}
