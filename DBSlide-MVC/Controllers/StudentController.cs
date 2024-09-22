using DBSlide_BLL.Entities;
using DBSlide_Common.Repositories;
using DBSlide_MVC.Handlers;
using DBSlide_MVC.Mapper;
using DBSlide_MVC.Models.Student;
using Microsoft.AspNetCore.Mvc;

namespace DBSlide_MVC.Controllers
{
    public class StudentController : Controller
    {
        private IStudentRepository<Student> _StudentRepository;
        private SessionManager _SessionManager;

        public StudentController(IStudentRepository<Student> studentRepository, SessionManager sessionManager)
        {
            _StudentRepository = studentRepository;
            _SessionManager = sessionManager;
        }

        #region CONNECTION
        #region - Login
        [NotConnectedAuthorize]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [NotConnectedAuthorize]
        public IActionResult Login(StudentLoginModel model)
        {
            try
            {
                if (!ModelState.IsValid) throw new Exception("Le formulaire contient des erreurs.");

                string? studentLogin = _StudentRepository.Login(model.Login);
                if (studentLogin is null) throw new Exception("Le login n'est pas valide.");
                _SessionManager.UserSession = new Models.UserSession()
                {
                    Login = model.Login,
                    LastConnection = DateTime.Now
                };
                return RedirectToAction("Index", "Student");
            }
            catch (Exception ex)
            {
                ViewBag.ErrorMessage = ex.Message;
                return View();
            }
        }
        #endregion
        #region - Logout
        [ConnectedAuthorize]
        public IActionResult Logout()
        {
            return View();
        }
        [HttpPost]
        [ConnectedAuthorize]
        public IActionResult Logout(string login)
        {
            _SessionManager.UserSession = null;
            return RedirectToAction("Index", "Home");
        }
        #endregion
        #endregion

        #region CREATE
        [ConnectedAuthorize]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [ConnectedAuthorize]
        public IActionResult Create(StudentInsertModel student)
        {
            if (!ModelState.IsValid) throw new Exception("Le formulaire n'est pas valide.");
            int studentId = _StudentRepository.Insert(student.ToBLL());
            return RedirectToAction("Details", new { StudentId = studentId });
        }
        #endregion

        #region READ
        #region - List
        [ConnectedAuthorize]
        public IActionResult Index()
        {
            IEnumerable<StudentListItemModel> model = _StudentRepository.Get().Select(e => e.ToListItem());
            return View(model);
        }
        #endregion
        #region - Details
        [ConnectedAuthorize]
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
        [ConnectedAuthorize]
        public IActionResult Edit([FromRoute] int StudentId)
        {
            StudentDetailsModel model = _StudentRepository.Get(StudentId).ToDetails();
            return View(model);
        }

        [HttpPost]
        [ActionName("Edit")]
        [ConnectedAuthorize]
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
        [ConnectedAuthorize]
        public IActionResult Delete([FromRoute] int StudentId)
        {
            StudentListItemModel model = _StudentRepository.Get(StudentId).ToListItem();
            return View(model);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ConnectedAuthorize]
        public IActionResult ConfirmeDelete(int StudentId)
        {
            _StudentRepository.Delete(StudentId);
            return RedirectToAction("Index");
        }
        #endregion
    }
}
