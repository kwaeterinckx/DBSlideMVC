using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSlide_MVC.Models.Student
{
    public class StudentLoginModel
    {
        [DisplayName("Login :")]
        [Required(ErrorMessage = "Veuillez entrer votre login.")]
        public string Login { get; set; }
    }
}
