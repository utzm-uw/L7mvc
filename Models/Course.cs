using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-utzm-dykstra2] - Class for course information get/set
    public class Course
    {
        //tinfo200:[2021-03-13-utzm-dykstra2] - Have a database generated
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int CourseID { get; set; }
        public string Title { get; set; }
        public int Credits { get; set; }

        //tinfo200:[2021-03-13-utzm-dykstra2] - Grabs the information from Enrollments, leads to Enrollments.cs
        public ICollection<Enrollment> Enrollments { get; set; }
    }
}