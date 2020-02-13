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
        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger)
        {
            _logger = logger;
        }

        /**
        * IActionResult : 내부 로직의 결과를 View에 매핑하여 리턴 - MVC 구조에 따라서 생성해야 매핑이 됨.
        * /Views/ 경로 내부에 해당 Controller 이름의 폴더를 생성한 뒤 IActionResult를 리턴하는 함수의 이름과 동일한 Razor View 파일 생성 (.cshtml 확장자)
        * teachers List 를 생성하여 StudentTeacherViewModel 을 View로 리턴한다.
        **/
        public IActionResult Index() 
        {
            List<TeacherModel> teachers = new List<TeacherModel>()
            {
                new TeacherModel() { Name = "T1", Class = "C1" },
                new TeacherModel() { Name = "T2", Class = "C2" },
                new TeacherModel() { Name = "T3", Class = "C3" },
                new TeacherModel() { Name = "T4", Class = "C4" }
            };

            var viewModel = new StudentTeacherViewModel()
            {
                Student = new StudentModel(),
                Teachers = teachers
            };

            return View(viewModel);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /**
        * HttpPost : HTML View 에서 넘어온 데이터 수신
        * StudentModel model : 넘어온 데이터를 자동으로 StudentModel 구조로 매핑
        * [Bind("Name, Age")] : 넘어오는 데이터 중 Name과 Age 데이터만 받아서 바인딩. 그 외의 데이터는 null로 처리.
        * [ValidateAntiForgeryToken] : User가 Server로 전송한 Form Data가 맞는지 Token 값을 비교한다.
        *       --> POST는 Token을 생성하여 Server로 데이터를 보낸다.
        **/
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Index([Bind("Name, Age")]StudentTeacherViewModel model)
        {
            // 유효성 검사 통과 여부 ( T : Pass, F : fail )
            if (ModelState.IsValid)
            {
                // model 데이터를 Student 테이블에 저장
            }
            else
            {
                // 에러 메시지    
            }

            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

    }
}
