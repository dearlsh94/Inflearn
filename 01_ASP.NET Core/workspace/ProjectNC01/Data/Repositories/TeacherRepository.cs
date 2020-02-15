namespace ProjectNC01.Data.Repositories
{
    public class TeacherRepository
    {
        private readonly ProjectNC01Context _context;

        public TeacherRepository(ProjectNC01Context context)
        {
            _context = context;
        }

        /*
         * Teacher List 전체 조회
         * IEnumerable : List 보다 효율성이 좋음
         */
         public IEnumerable<Teacher> GetAllTeachers()
         {
             var result = _context.Teachers.ToList();

             return result;
         }

         /*
          * Id를 통한 특정 데이터 조회
          */
          public Teacher GetTeacher(string id)
          {
              var result = _context.Teachers.Find(id);

              return result;
          }
    }
}