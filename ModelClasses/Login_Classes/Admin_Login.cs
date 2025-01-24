using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace ModelClasses.Login_Classes
{
    public class Admin_Login
    {
        [Key]
        public int AdminId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Admin Name")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Admin Email")]
        [EmailAddress(ErrorMessage = "please provide proper Emailid")]
        public string AdminEmail { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Admin Mobile")]
        [StringLength(10, MinimumLength = 10, ErrorMessage = "please provide proper mobile number")]
        public string AdminMobile { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Admin Password")]
        public string AdminPassword { get; set; }
    }
}
