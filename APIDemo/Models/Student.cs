namespace APIDemo.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime? CreatedOn { get; set; }

        public Grade? Grade { get; set; }
        public int GradeID { get; set; }
    }
}
