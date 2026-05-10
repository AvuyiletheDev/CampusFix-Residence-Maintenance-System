using CampusFix.Domain.Entities;
using CampusFix.Domain.Interfaces;

namespace CampusFix.Application.Services
{
    public class MaintenanceRequestService
    {
        private readonly IMaintenanceRequestRepository _requestRepository;
        private readonly ITechnicianRepository _technicianRepository;

        public MaintenanceRequestService(
            IMaintenanceRequestRepository requestRepository,
            ITechnicianRepository technicianRepository)
        {
            _requestRepository = requestRepository;
            _technicianRepository = technicianRepository;
        }

        public IReadOnlyList<MaintenanceRequest> GetAllRequests()
        {
            return _requestRepository.FindAll();
        }

        public MaintenanceRequest? GetRequestById(string id)
        {
            return _requestRepository.FindById(id);
        }

        public void SaveRequest(MaintenanceRequest request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            _requestRepository.Save(request);
        }

        public void AssignTechnician(string requestId, string technicianId)
        {
            var request = _requestRepository.FindById(requestId);

            if (request == null)
            {
                throw new InvalidOperationException("Maintenance request not found.");
            }

            var technician = _technicianRepository.FindById(technicianId);

            if (technician == null)
            {
                throw new InvalidOperationException("Technician not found.");
            }

            request.AssignTechnician(technician.Id);

            _requestRepository.Save(request);
        }

        public void DeleteRequest(string id)
        {
            _requestRepository.Delete(id);
        }
    }
}