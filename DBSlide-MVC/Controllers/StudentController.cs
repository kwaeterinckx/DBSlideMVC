using DBSlide_BLL.Entities;
using DBSlide_Common.Repositories;
using DBSlide_MVC.Mapper;
using DBSlide_MVC.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace DBSlide_MVC.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository<Student> _StudentRepository;

        public StudentController(IStudentRepository<Student> studentRepository)
        {
            _StudentRepository = studentRepository;
        }

        public IActionResult Index()
        {
            IEnumerable<StudentListItemModel> model = _StudentRepository.Get().Select(e => e.ToListItem());
            return View(model);
        }

        [Route("Student/Details/{StudentId:int}")]
        public IActionResult Details([FromRoute]int StudentId)
        {
            StudentDetailsModel model = _StudentRepository.Get(StudentId).ToDetails();
            return View(model);
        }
    }
}
