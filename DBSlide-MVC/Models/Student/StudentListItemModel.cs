using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSlide_MVC.Models.Student
{
    public class StudentListItemModel
    {
        [ScaffoldColumn(false)]
        public int StudentId { get; set; }

        [DisplayName("Prénom")]
        public string FirstName { get; set; }

        [DisplayName("Nom")]
        public string LastName { get; set; }
    }
}
