using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DBSlide_MVC.Models.Student
{
    public class StudentInsertModel
    {
        [DisplayName("Prénom :")]
        [Required(ErrorMessage = "Veuillez entrer un prénom.")]
        [MaxLength(50, ErrorMessage = "Le prénom ne peut contenir au maximum 50 caractères.")]
        public string FirstName { get; set; }

        [DisplayName("Nom :")]
        [Required(ErrorMessage = "Veuillez entrer un nom.")]
        [MaxLength(50, ErrorMessage = "Le nom ne peut contenir au maximum 50 caractères.")]
        public string LastName { get; set; }

        [DisplayName("Date de naissance :")]
        [Required(ErrorMessage = "Veuillez indiquer la date de naissance.")]
        [DataType(DataType.Date)]
        public DateTime BirthDate { get; set; }

        [DisplayName("Section :")]
        [Required(ErrorMessage = "Veuillez indiquer le numéro de section.")]
        [DataType("number")]
        public int SectionId { get; set; }

        [DisplayName("Résultat annuel :")]
        [DataType("number")]
        public int? YearResult { get; set; }

        [DisplayName("Cours :")]
        public string? CourseId { get; set; }
    }
}
