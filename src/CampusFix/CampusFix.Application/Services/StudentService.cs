using CampusFix.Domain.Entities;
using CampusFix.Domain.Interfaces;

namespace CampusFix.Application.Services
{
    public class StudentService
    {
        private readonly IStudentRepository _studentRepository;

        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public IReadOnlyList<Student> GetAllStudents()
        {
            return _studentRepository.FindAll();
        }

        public Student? GetStudentById(string id)
        {
            return _studentRepository.FindById(id);
        }

        public void SaveStudent(Student student)
        {
            if (student == null)
            {
                throw new ArgumentNullException(nameof(student));
            }

            _studentRepository.Save(student);
        }

        public void DeleteStudent(string id)
        {
            _studentRepository.Delete(id);
        }
    }
}