using CrudStudentAPI.Models;
using System.Collections.Generic;
using System.Linq;


namespace CrudStudentAPI.Data
{
    public class StudentRepository : IStudentRepository
    {
        private readonly AppDbContext _context;
        
        public StudentRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public Student? GetStudentById(int id)
        {
            return _context.Students.FirstOrDefault(s => s.Id == id);
        }
        public Student AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
            return student;
        }   

    }
}