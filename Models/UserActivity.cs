using System.ComponentModel.DataAnnotations;

namespace Rushika_Solutions.Models
{
    public class UserActivity
    {
        [Display(Name = "Created By Id")]
        public string? CreatedById { get; set; }
        [Display(Name = "Created On")]
        public DateTime CreatedOn { get; set; }
        [Display(Name = "Modified By Id")]
        public string? ModifiedById { get; set; }
        [Display(Name = "Modified On")]
        public DateTime ModifiedOn { get; set; }

    }
}
