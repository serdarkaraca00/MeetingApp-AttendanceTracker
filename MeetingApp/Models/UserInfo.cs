using System.ComponentModel.DataAnnotations;

namespace MeetingApp.Models
{
    public class UserInfo
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Namespace is required")]
        public string?  Name { get; set; } // null

        [Required(ErrorMessage ="Phonespace is required")]
        public string?  Phone { get; set; }
        
        [Required(ErrorMessage ="Mailspace is required")]
        [EmailAddress(ErrorMessage ="Incorrect email")]
        public string?  Email { get; set; }
        
        [Required(ErrorMessage ="Please indicate your participation status.")]
        public bool? WillAttend { get; set; } // true, false, null
    }
}