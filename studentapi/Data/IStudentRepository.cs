using CrudStudentAPI.Models;
using System.Collections.Generic;

namespace CrudStudentAPI.Data
{
    public interface IStudentRepository
    {
        IEnumerable<Student> GetAllStudents();
        Student? GetStudentById(int id);
        Student AddStudent(Student student);
    }
}   