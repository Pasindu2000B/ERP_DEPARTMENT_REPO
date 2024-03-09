using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases
{
    public class GetTrainingRequests : IGetTrainingRequests
    {
        private readonly ITrainingRepository _trainingRepository;
        public GetTrainingRequests(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
        }
        public async Task<IEnumerable<StudentRequest>>ExecuteAsync(string name="")
        {
            return await _trainingRepository.GetAllTrainingRequestsAsync(name);
        }
    }
}
