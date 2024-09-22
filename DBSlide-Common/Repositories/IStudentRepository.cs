using DBSlide_Common.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DBSlide_Common.Repositories
{
    public interface IStudentRepository<TStudent> where TStudent : IStudent
    {
        #region Login
        public string? Login(string login);
        #endregion

        #region Create
        public int Insert(TStudent student);
        #endregion

        #region Read
        public IEnumerable<TStudent> Get();
        public TStudent Get(int studentId);
        #endregion

        #region Update
        public int Update(TStudent student);
        #endregion

        #region Delete
        public void Delete(int studentId);
        #endregion
    }
}
