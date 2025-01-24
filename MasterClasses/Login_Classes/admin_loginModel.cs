using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasterClasses.Login_Classes
{
    public class admin_loginModel
    {
        [Key]
        public int AdminId { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Admin Name")]
        public string AdminName { get; set; }

        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Admin Email")]
        [EmailAddress(ErrorMessage ="please provide proper Emailid")]
        public string AdminEmail { get; set; }
        [Required(ErrorMessage ="This field is required")]
        [DisplayName("Admin Mobile")]
        [StringLength(10,MinimumLength =10,ErrorMessage ="please provide proper mobile number")]
        public string AdminMobile { get; set; }
        [Required(ErrorMessage = "This field is required")]
        [DisplayName("Admin Password")]
        public string AdminPassword { get; set; }
    }
}
