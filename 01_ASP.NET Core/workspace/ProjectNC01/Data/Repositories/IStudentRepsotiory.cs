namespace ProjectNC01.Data.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(Student student);
        IEnumerable<Student> GetAllStudents();
        Student GetStudent(string id);
        void Edit(Student student);
        void Delete(Student student);
        void Save();
    }
}