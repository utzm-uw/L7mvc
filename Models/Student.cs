using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-utzm-dykstra2] - Grabs student information for code and sets it
    public class Student
    {
        //tinfo200:[2021-03-13-utzm-dykstra2] - Student ID in the system, main key for seperating users
        public int ID { get; set; }

        //tinfo200:[2021-03-13-utzm-dykstra2] - Student information
        public string LastName { get; set; }
        public string FirstMidName { get; set; }
        public DateTime EnrollmentDate { get; set; }

        //tinfo200:[2021-03-13-utzm-dykstra2] - Navagation property hold more elements, leads to Enrollment.cs
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}