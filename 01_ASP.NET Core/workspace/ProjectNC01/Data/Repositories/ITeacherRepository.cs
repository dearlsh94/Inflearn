using System.Collections.Generic;
using ProjectNC01.Models;

namespace ProjectNC01.Data.Repositories
{
    public interface ITeacherRepository
    {
        IEnumerable<TeacherModel> GetAllTeachers();
        TeacherModel GetTeacher(string id);
    }
}