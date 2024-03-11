using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.InternShips;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.Usecases
{
    public class FileUploadUseCase : IFileUploadUseCase
    {
        private readonly ITrainingRepository _trainingRepository;
        public FileUploadUseCase (ITrainingRepository trainingRepository)
        {
            _trainingRepository = trainingRepository;
            
        }
        public async Task UploadFileAsync(FileUpload fileupload)
        {
            await _trainingRepository.SaveFileAsync(fileupload);
        }
    }
}
