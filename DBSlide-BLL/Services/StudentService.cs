using DBSlide_BLL.Entities;
using DBSlide_BLL.Mapper;
using DBSlide_Common.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DAL = DBSlide_DAL.Entities;

namespace DBSlide_BLL.Services
{
    public class StudentService : IStudentRepository<Student>
    {
        private IStudentRepository<DAL.Student> _StudentService;

        public StudentService(IStudentRepository<DAL.Student> studentService)
        {
            _StudentService = studentService;
        }

        #region CREATE
        public int Insert(Student student)
        {
            return _StudentService.Insert(student.ToDAL());
        }
        #endregion

        #region READ
        #region - List
        public IEnumerable<Student> Get()
        {
            return _StudentService.Get().Select(e => e.ToBLL());
        }
        #endregion
        #region - Details
        public Student Get(int studentId)
        {
            return _StudentService.Get(studentId).ToBLL();
        }
        #endregion
        #endregion

        #region UPDATE
        public int Update(Student student)
        {
            return _StudentService.Update(student.ToDAL());
        }
        #endregion

        #region DELETE
        public void Delete(int studentId)
        {
            _StudentService.Delete(studentId);
        }
        #endregion
    }
}
