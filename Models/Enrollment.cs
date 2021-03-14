namespace ContosoUniversity.Models
{
    //tinfo200:[2021-03-13-utzm-dykstra2] - Shows the different grades with enum
    public enum Grade
    {
        A, B, C, D, F
    }

    //tinfo200:[2021-03-13-utzm-dykstra2] - Information displaying the student information and course information
    public class Enrollment
    {
        public int EnrollmentID { get; set; }
        public int CourseID { get; set; }
        public int StudentID { get; set; }
        public Grade? Grade { get; set; }

        //tinfo200:[2021-03-13-utzm-dykstra2] - Two get/set's that grab information from the Course.cs (Course information)
        //tinfo200:[2021-03-13-utzm-dykstra2] - and Student.cs (Student Information)
        public Course Course { get; set; }
        public Student Student { get; set; }
    }
}