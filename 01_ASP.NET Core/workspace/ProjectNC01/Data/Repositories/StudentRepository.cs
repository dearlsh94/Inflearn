using System.Collections.Generic;
using ProjectNC01.Models;

namespace ProjectNC01.Data.Repositories
{
    public class StudentRepository : IStudentRepository
    {
        private readonly ProjectNC01Context _context;
/* 
        public StudentRepository(ProjectNC01Context context)
        {
            _context = context;
        }
*/
        public void AddStudent(StudentModel student)
        {
            // _context.Students.Add(student);
        }

        /*
         * Teacher List 전체 조회
         * IEnumerable : List 보다 효율성이 좋음
         */
         public IEnumerable<StudentModel> GetAllStudents()
         {
             //var result = _context.Students.ToList();
             var result = new List<StudentModel>
             {
                 new StudentModel(),
             };

             return result;
         }
        

        /*
        * Id를 통한 특정 데이터 조회
        */
        public StudentModel GetStudent(string id)
        {
            //var result = _context.Students.Find(id);
            var result = new StudentModel();
            
            return result;
        }
        
        
        public void Edit(StudentModel student)
        {
            // _context.Update(Student);
        }

        public void Delete(StudentModel student)
        {
            // _context.Remove(student);
        }
        
        public void Save()
        {
            // _context.SaveChanges();
        }
         
    }
}