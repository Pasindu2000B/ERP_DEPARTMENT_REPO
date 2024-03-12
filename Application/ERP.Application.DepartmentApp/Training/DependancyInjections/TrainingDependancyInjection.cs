using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.UseCases;
using ERP.Application.DepartmentApp.Labs.Interfaces;
using ERP.Application.DepartmentApp.Labs.UseCases;
using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Application.DepartmentApp.Training.Usecases;
using ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ERP.Application.DepartmentApp.Training.DependancyInjections
{
    public static class TrainingDependancyInjection
    {
        public static IServiceCollection TrainingServices(
           this IServiceCollection services)
        {
            services.AddScoped<IStudentRequestCreateUseCase, StudentRequestUseCase>();
            services.AddScoped<IInternPostUseCase, InternPostUseCasecs>();
            services.AddScoped<IInternPostViewUseCase, InternViewUseCase>();
            services.AddScoped<IGetTrainingRequests, GetTrainingRequests>();
            services.AddScoped<IFileUploadUseCase, FileUploadUseCase>();
            services.AddScoped<IGetFileListUseCase, GetFileListUseCase>();
        
            return services;
        }
    }
}
