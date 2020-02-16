using System.Collections.Generic;
using ProjectNC01.Models;

namespace ProjectNC01.Data.Repositories
{
    public class TeacherRepository : ITeacherRepository
    {
        private readonly ProjectNC01Context _context;
/*
        public TeacherRepository(ProjectNC01Context context)
        {
            _context = context;
        }
 */
        /*
         * Teacher List 전체 조회
         * IEnumerable : List 보다 효율성이 좋음
         */
         public IEnumerable<TeacherModel> GetAllTeachers()
         {
             // var result = _context.Teachers.ToList();
             var result = new List<TeacherModel>()
            {
                new TeacherModel() { Name = "T1", Class = "C1" },
                new TeacherModel() { Name = "T2", Class = "C2" },
                new TeacherModel() { Name = "T3", Class = "C3" },
                new TeacherModel() { Name = "T4", Class = "C4" }
            };

             return result;
         }
         
         
         /*
          * Id를 통한 특정 데이터 조회
          */
          public TeacherModel GetTeacher(string id)
          {
              // var result = _context.Teachers.Find(id);
              var result = new TeacherModel() { Name = "T1", Class = "C1" };

              return result;
          }
          
    }
}