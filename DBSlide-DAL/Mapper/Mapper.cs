using System;
using System.Collections.Generic;
using System.Data;
using System.Text;
using DBSlide_DAL.Entities;

namespace DBSlide_DAL.Mapper
{
    internal static class Mapper
    {
        #region Student
        public static Student ToDAL(this IDataRecord record)
        {
            if (record is null) throw new ArgumentNullException(nameof(record));

            return new Student()
            {
                StudentId = (int)record[nameof(Student.StudentId)],
                FirstName = (string)record[nameof(Student.FirstName)],
                LastName = (string)record[nameof(Student.LastName)],
                BirthDate = (DateTime)record[nameof(Student.BirthDate)],
                Login = (string)record[nameof(Student.Login)],
                SectionId = (int)record[nameof(Student.SectionId)],
                YearResult = (record[nameof(Student.YearResult)] is DBNull) ? null : (int?)record[nameof(Student.YearResult)],
                CourseId = (record[nameof(Student.CourseId)] is DBNull) ? null : (string?)record[nameof(Student.CourseId)]
            };
        }
        #endregion
    }
}
