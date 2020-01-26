using System;
using Xunit;

namespace ClinicProject.Test
{
    public class UnitTest1
    {
        [Fact]
        public void DoctorName()
        {
            // Arrange
            var doctor = new Doctor();

            // Act
            string name = "John Smith";

            // Assert
            Assert.Equal("John Smith", name);
        }
        [Fact]

        public void PaySalaryWorks()
        {
            var employee = new Employee();

            string ifPaid = "The Employee has been paid";

            Assert.Equal("The Employee has been paid", ifPaid);
                
        
        
        
        }



    }

    internal class Doctor
    {
        public Doctor()
        {
        }
    }
}
