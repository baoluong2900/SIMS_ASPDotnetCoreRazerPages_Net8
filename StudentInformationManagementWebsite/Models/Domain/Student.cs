namespace StudentInformationManagementWebsite.Models.Domain
{
    public class Student
    {
        public Guid StudentID { get; set; }
        public string LastName { get; set; }

        public string UrlHandle { get; set; }

        public string FirstName { get; set; }
        public string Email { get; set; }
        public DateTime DateOfBirth { get; set; }
    }
}
