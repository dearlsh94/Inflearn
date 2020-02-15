using System.Collections.Generic;
using ProjectNC01.Models;

namespace ProjectNC01.ViewModels
{
    public class StudentTeacherViewModel
    {
        public StudentModel Student { get; set; }
        public IEnumerable<TeacherModel> Teachers { get; set; }
        public IEnumerable<StudentModel> Students { get; set; }
    }
}
