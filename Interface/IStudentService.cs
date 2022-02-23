using System.Threading.Tasks;
using APIDay10.DTO;

namespace APIDay10.Interface
{
    public interface IStudentService
    {
        //void AddTask(StudentDTO task);
        StudentDTO GetStudent(int id);

        Task AddStudent(StudentDTO dto );

        void UpdateStudent(StudentDTO dto);

        void DeleteStudent(StudentDTO dto);

    }
}