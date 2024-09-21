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

        public IEnumerable<Student> Get()
        {
            return _StudentService.Get().Select(e => e.ToBLL());
        }

        public Student Get(int studentId)
        {
            return _StudentService.Get(studentId).ToBLL();
        }
    }
}
