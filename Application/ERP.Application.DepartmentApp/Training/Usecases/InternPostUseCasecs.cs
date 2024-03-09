using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases
{
    public class InternPostUseCasecs : IInternPostUseCase
    {
        private ITrainingRepository _trainingRepository;

        public InternPostUseCasecs(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
            
        }

        public async Task ExecuteAsync(StudentRequest studentRequest)
        {
            await _trainingRepository.SendStudentRequestAsync(studentRequest);

        }
        public async Task AddExecuteAsync(JobPost jobPost)
        {
            await _trainingRepository.AddJobPostAsync(jobPost);
        }

        public async Task DeleteExecuteAsync(JobPost jobPost)
        {
            await _trainingRepository.RemoveJobPostAsync(jobPost);
        }

        public async Task EditExecuteAsync(JobPost jobPost)
        {
            await _trainingRepository.EditJobPostAsync(jobPost);
        }
    }

}
