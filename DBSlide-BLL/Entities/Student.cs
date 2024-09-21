using DBSlide_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using DAL = DBSlide_DAL.Entities;

namespace DBSlide_BLL.Entities
{
    public class Student : IStudent
    {
        private string _Login;

        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime BirthDate { get; set; }
        public string Login
        {
            get
            {
                return (FirstName.Substring(0, 1) + LastName.Replace(" ", "").Substring(0, 7)).ToLower();
            }
        }
        public int SectionId { get; set; }
        public int? YearResult { get; set; }
        public string? CourseId { get; set; }

        public Student(string firstName, string lastName, DateTime birthDate, int sectionId, int? yearResult, string? courseId)
        {
            FirstName = firstName;
            LastName = lastName;
            BirthDate = birthDate;
            SectionId = sectionId;
            YearResult = yearResult;
            CourseId = courseId;
        }

        public Student(DAL.Student student)
        {
            StudentId = student.StudentId;
            FirstName = student.FirstName;
            LastName = student.LastName;
            BirthDate = student.BirthDate;
            _Login = student.Login;
            SectionId = student.SectionId;
            YearResult = student.YearResult;
            CourseId = student.CourseId;
        }
    }
}
