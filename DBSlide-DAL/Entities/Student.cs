using DBSlide_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSlide_DAL.Entities
{
    public class Student : IStudent
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login { get; set; }
        public int SectionId { get; set; }
        public string? SectionName { get; set; }
        public int? YearResult { get; set; }
        public string? CourseId { get; set; }
    }
}
