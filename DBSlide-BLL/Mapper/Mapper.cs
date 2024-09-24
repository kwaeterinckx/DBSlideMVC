using System;
using System.Collections.Generic;
using System.Text;
using BLL = DBSlide_BLL.Entities;
using DAL = DBSlide_DAL.Entities;

namespace DBSlide_BLL.Mapper
{
    internal static class Mapper
    {
        #region Student
        public static BLL.Student ToBLL(this DAL.Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));

            return new BLL.Student(student);
        }
        public static DAL.Student ToDAL(this BLL.Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));

            return new DAL.Student()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDate = student.BirthDate,
                Login = student.Login,
                SectionId = student.SectionId,
                SectionName = student.SectionName,
                YearResult = student.YearResult,
                CourseId = student.CourseId
            };
        }
        #endregion
    }
}
