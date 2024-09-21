using DBSlide_MVC.Models.Student;
using BLL = DBSlide_BLL.Entities;

namespace DBSlide_MVC.Mapper
{
    internal static class Mapper
    {
        #region Student
        public static StudentListItemModel ToListItem(this BLL.Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));

            return new StudentListItemModel()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName
            };
        }
        public static StudentDetailsModel ToDetails(this BLL.Student student)
        {
            if (student is null) throw new ArgumentNullException(nameof(student));

            return new StudentDetailsModel()
            {
                StudentId = student.StudentId,
                FirstName = student.FirstName,
                LastName = student.LastName,
                BirthDate = student.BirthDate,
                Login = student.Login,
                SectionId = student.SectionId,
                YearResult = student.YearResult,
                CourseId = student.CourseId
            };
        }
        #endregion
    }
}
