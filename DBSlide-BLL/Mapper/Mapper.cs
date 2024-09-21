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
        #endregion
    }
}
