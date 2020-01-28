using System;

namespace UniversityClinicProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee NewEmployee = new Employee();
            Nurse NewNurse = new Nurse();
            Receptionist NewReceptionist = new Receptionist();
            Janitor NewJanitor = new Janitor();
            Patient NewPatient = new Patient();

            Employee FirstEmployee = new Employee("Tom", 321);
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
            Doctor newDoctor = new Doctor("Doctor Bob", 869843, true, "neurosurgeon");
            Console.WriteLine($"{newDoctor.Name}, {newDoctor.IDNumber}, {newDoctor.Salary}, {newDoctor.Paid}, {newDoctor.Specialty}");

            Doctor secondDoctor = new Doctor();
            secondDoctor.Name = "Dr. Phil";
            Console.WriteLine(secondDoctor.Name);

        }
    }
}
