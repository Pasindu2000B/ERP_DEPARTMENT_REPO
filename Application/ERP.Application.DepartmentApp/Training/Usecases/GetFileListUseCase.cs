using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases
{
    public class GetFileListUseCase : IGetFileListUseCase
    {
        private readonly ITrainingRepository _trainingRepository;

        public GetFileListUseCase(ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;

        }
        public async Task<IEnumerable<FileUpload>> ExecuteAsync() => await _trainingRepository.GetAllFilesAsync();
    }
}
