using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ProjectNC01.Models;
using ProjectNC01.ViewModels;

namespace ProjectNC01.Controllers
{
    public class StudentController : Controller
    {
        private readonly ITeachersRepository _teacherRepository;
        private readonly IStudentRepository _studentRepository;
        private readonly ILogger<StudentController> _logger;

        private List<TeacherModel> teachers = new List<TeacherModel>()
            {
                new TeacherModel() { Name = "T1", Class = "C1" },
                new TeacherModel() { Name = "T2", Class = "C2" },
                new TeacherModel() { Name = "T3", Class = "C3" },
                new TeacherModel() { Name = "T4", Class = "C4" }
            };
        
        public StudentController(ITeachersRepository teacherRepository, IStudentRepository studentRepository)
        {
            _teacherRepository = teacherRepository;
            _studentRepository = studentRepository;
        }

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            var teachers = _teacherRepository.GetAllTeachers();

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new StudentModel(),
                Teachers = teachers
            };

            return View(viewModel);
        }

        /*
         * IActionResult : 내부 로직의 결과를 View에 매핑하여 리턴 - MVC 구조에 따라서 생성해야 매핑이 됨.
         * /Views/ 경로 내부에 해당 Controller 이름의 폴더를 생성한 뒤 IActionResult를 리턴하는 함수의 이름과 동일한 Razor View 파일 생성 (.cshtml 확장자)
         * teachers List 를 생성하여 StudentTeacherViewModel 을 View로 리턴한다.
         * [Authorize] : Login 된 유저만 접근 가능. 
         */
        [Authorize]
        public IActionResult Student() 
        {
            var students = studentRepository.getAllStudents();

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new StudentModel(),
                Students = students
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*
         * HttpPost : HTML View 에서 넘어온 데이터 수신
         * StudentModel model : 넘어온 데이터를 자동으로 StudentModel 구조로 매핑
         * [Bind("Name, Age")] : 넘어오는 데이터 중 Name과 Age 데이터만 받아서 바인딩. 그 외의 데이터는 null로 처리.
         * [ValidateAntiForgeryToken] : User가 Server로 전송한 Form Data가 맞는지 Token 값을 비교한다.
         *       --> POST는 Token을 생성하여 Server로 데이터를 보낸다.
         */
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Student([Bind("Name, Age")]StudentModel model)
        {
            var viewModel = new StudentTeacherViewModel();
            viewModel.Student = model;
            viewModel.Teachers = teachers;
            
            // 유효성 검사 통과 여부 ( T : Pass, F : fail )
            if (ModelState.IsValid)
            {
                // model 데이터를 Student 테이블에 저장
                studentRepository.AddStudent(model.Student);
                studentRepository.Save();

                // Clear Input Data
                ModelState.Clear();
            }
            else
            {
                // 에러 메시지    
            }

            var students = studentRepository.getAllStudents();
            viewModel.Student = new Student();
            viewModel.Students = students;

            return View(viewModel);
        }

        public IActionResult Detail(string Id)
        {
            Student result = _studentRepository.getStudent(Id);

            return View(result);
        }

        public IActionResult Edit(string Id)
        {
            var result = _studentRepository.GetStudent(id);

            return result;
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Edit(Student student)
        {
            if (ModelState.IsValid)
            {
                _studentRepository.Edit(Id);
                studentRepository.Save();
                
                result = _studentRepository.getStudent(Id);
                
                return RedirectToAction("Student");
            }
            
            return View(student);
        }

        public IActionResult Delete(int id)
        {
            var result = _studentRepository.GetStudent(id);

            if (result != null)
            {
                _studentRepository.Delete(student);
                _studentRepository.Save();
            }

            return RedirectToAction("Student");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
