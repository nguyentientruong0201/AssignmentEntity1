using System.Security.Authentication;
using APIDay10.Entities;
using APIDay10.DTO;

namespace APIDay10.Infinities {
    public static class Infinity {
        public static StudentDTO EntityToDTO(this Student entity){
            return new StudentDTO {
                FirstName = entity.FirstName,
                LastName = entity.LastName,
                City = entity.City,
                State = entity.State
            };
        }

        public static Student DTOToEntity(this StudentDTO dto){
            return new Student{
                FirstName = dto.FirstName,
                LastName = dto.LastName,
                City = dto.City,
                State = dto.State
             };
        }
    }
}