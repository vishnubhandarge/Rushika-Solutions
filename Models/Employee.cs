using System.ComponentModel.DataAnnotations;

namespace Rushika_Solutions.Models
{
    public class Employee: UserActivity
    {
        [Key]
        public int id { get; set; }

        public string EmpNo { get; set; }

        [Display(Name = "First Name")]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        public string LastName { get; set; }
        public string Fullname => $"{FirstName} {MiddleName} {LastName}";

        [Display(Name = "Phone Number")]
        public int PhoneNumber { get; set; }

        [Display(Name = "Email Address")]
        public string EmailAddress { get; set; }
        public string Country { get; set; }


        [Display(Name = "Date Of Birth")]
        public DateTime DateOfBirth { get; set; }
        public string Address { get; set; }
        public string Department { get; set; }
        public string Designatoin { get; set; }
    }
}
