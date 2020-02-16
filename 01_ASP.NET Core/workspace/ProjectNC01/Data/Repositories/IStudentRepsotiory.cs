using System.Collections.Generic;
using ProjectNC01.Models;

namespace ProjectNC01.Data.Repositories
{
    public interface IStudentRepository
    {
        void AddStudent(StudentModel student);
        IEnumerable<StudentModel> GetAllStudents();
        StudentModel GetStudent(string id);
        void Edit(StudentModel student);
        void Delete(StudentModel student);
        void Save();
    }
}