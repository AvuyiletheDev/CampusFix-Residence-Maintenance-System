using CampusFix.Domain.Entities;
using CampusFix.Domain.Interfaces;

namespace CampusFix.Application.Services
{
    public class TechnicianService
    {
        private readonly ITechnicianRepository _technicianRepository;

        public TechnicianService(ITechnicianRepository technicianRepository)
        {
            _technicianRepository = technicianRepository;
        }

        public IReadOnlyList<Technician> GetAllTechnicians()
        {
            return _technicianRepository.FindAll();
        }

        public Technician? GetTechnicianById(string id)
        {
            return _technicianRepository.FindById(id);
        }

        public void SaveTechnician(Technician technician)
        {
            if (technician == null)
            {
                throw new ArgumentNullException(nameof(technician));
            }

            _technicianRepository.Save(technician);
        }

        public void DeleteTechnician(string id)
        {
            _technicianRepository.Delete(id);
        }
    }
}