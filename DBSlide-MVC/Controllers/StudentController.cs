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

        #region CREATE
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(StudentInsertModel student)
        {
            if (!ModelState.IsValid) throw new Exception("Le formulaire n'est pas valide.");
            int studentId = _StudentRepository.Insert(student.ToBLL());
            return RedirectToAction("Details", new { StudentId = studentId });
        }
        #endregion

        #region READ
        #region - List
        public IActionResult Index()
        {
            IEnumerable<StudentListItemModel> model = _StudentRepository.Get().Select(e => e.ToListItem());
            return View(model);
        }
        #endregion
        #region - Details
        [Route("Student/Details/{StudentId:int}")]
        public IActionResult Details([FromRoute] int StudentId)
        {
            StudentDetailsModel model = _StudentRepository.Get(StudentId).ToDetails();
            return View(model);
        }
        #endregion
        #endregion

        #region UPDATE
        [HttpGet]
        [Route("Student/Edit/{StudentId:int}")]
        public IActionResult Edit([FromRoute] int StudentId)
        {
            StudentDetailsModel model = _StudentRepository.Get(StudentId).ToDetails();
            return View(model);
        }

        [HttpPost]
        [ActionName("Edit")]
        public IActionResult ConfirmeEdit(StudentDetailsModel model)
        {
            if (!ModelState.IsValid) throw new Exception("Le formulaire n'est pas valide.");

            int studentId = _StudentRepository.Update(model.ToBLL());
            return RedirectToAction("Details", new { StudentId = studentId });
        }
        #endregion

        #region DELETE
        [HttpGet]
        [Route("Student/Delete/{StudentId:int}")]
        public IActionResult Delete([FromRoute] int StudentId)
        {
            StudentListItemModel model = _StudentRepository.Get(StudentId).ToListItem();
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        public IActionResult ConfirmeDelete(int StudentId)
        {
            _StudentRepository.Delete(StudentId);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
