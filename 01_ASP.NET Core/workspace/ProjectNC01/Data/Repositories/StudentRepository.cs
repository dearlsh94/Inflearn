namespace ProjectNC01.Data.Repositories
{
    public class StudentRepository
    {
        private readonly ProjectNC01Context _context;

        public StudentRepository(ProjectNC01Context context)
        {
            _context = context;
        }

        public void AddStudent(Student student)
        {
            _context.Student.Add(student);
        }

        /*
         * Teacher List 전체 조회
         * IEnumerable : List 보다 효율성이 좋음
         */
         public IEnumerable<Student> GetAllStudents()
         {
             var result = _context.Students.ToList();

             return result;
         }

        /*
        * Id를 통한 특정 데이터 조회
        */
        public Student GetStudent(string id)
        {
            var result = _context.Students.Find(id);

            return result;
        }

        public void Edit(Student student)
        {
            _context.Update(Student);
        }

        public void Delete(Student student)
        {
            _context.Remove(student);
        }
        
        public void Save()
        {
            _context.SaveChanges();
        }
         
    }
}