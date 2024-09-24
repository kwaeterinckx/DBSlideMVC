using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSlide_MVC.Models.Student
{
    public class StudentDetailsModel
    {
        [ScaffoldColumn(false)]
        public int StudentId { get; set; }

        [DisplayName("Prénom")]
        public string FirstName { get; set; }

        [DisplayName("Nom")]
        public string LastName { get; set; }

        [DisplayName("Date de naissance")]
        public DateTime BirthDate { get; set; }

        [DisplayName("Login")]
        public string Login { get; set; }

        [ScaffoldColumn(false)]
        public int SectionId { get; set; }

        [DisplayName("Section")]
        public string? SectionName { get; set; }

        [DisplayName("Résultat annuel")]
        public int? YearResult { get; set; }

        [DisplayName("Cours")]
        public string? CourseId { get; set; }
    }
}
