using System.ComponentModel.DataAnnotations;

namespace MvcTechdaysBlog.Models
{
    public class LogOnViewModel
    {
        [Required]
        [Display(Name = "User name")]
        public string UserName { get; set; }
        [Required]
        [DataType(DataType.Password)]
        [Display(Name = "Password")]
        public string Password { get; set; }
    }
}