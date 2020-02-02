using System;
using System.Collections.Generic;
using System.Text;

namespace UniversityClinicProject
{
    public class Patient
    {
        //Properties
        private int bloodLevel;
        private int healthStatus;
       public int BloodLevel { get; set; }
       public int HealthStatus {get; set; }

        //Constructor
        public Patient()
        {
            BloodLevel = 20;
            HealthStatus = 10;
        }

        //Methods
        public void DisplayBloodLevelandHealth()
        {
            Console.WriteLine($"Blood Level: {BloodLevel} | Health Status:  {HealthStatus}");
        
        }
    }
}
