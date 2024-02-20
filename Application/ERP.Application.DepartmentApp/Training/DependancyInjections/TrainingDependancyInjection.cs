using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.UseCases;
using ERP.Application.DepartmentApp.Labs.Interfaces;
using ERP.Application.DepartmentApp.Labs.UseCases;
using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Application.DepartmentApp.Training.Usecases.CRUD;
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
        
            services.AddScoped<IAddJobPostingUseCase, AddJobPostingUseCase>();
            services.AddScoped<IEditJobPostUseCase, EditJobPostingUseCase>();
            return services;
        }
    }
}
