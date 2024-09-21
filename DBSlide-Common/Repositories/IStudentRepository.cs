using DBSlide_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSlide_Common.Repositories
{
    public interface IStudentRepository<TStudent> where TStudent : IStudent
    {
        #region Create

        #endregion

        #region Read
        public IEnumerable<TStudent> Get();
        public TStudent Get(int studentId);
        #endregion

        #region Update

        #endregion

        #region Delete

        #endregion
    }
}
