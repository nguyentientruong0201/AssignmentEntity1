using APIDay10.DB;
using APIDay10.DTO;
using APIDay10.Entities;
using APIDay10.Interface;
//using APIDay10.Interface;

namespace APIDay10.Services
{
    public class StudentServices : IStudentService
    {
        private StudentContext _context;

        public StudentServices(StudentContext context)
        {
            _context = context;
        }

        public async Task AddStudent(StudentDTO student)
        {
            await _context.AddAsync(student.dto.DTOToEntity());
            await _context.SaveChangesAsync();
        }

        public void DeletePerson(int id) {
           
        }
    }
}