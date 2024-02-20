using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ERP.Application.DepartmentApp.Labs.Repository;
using ERP.Application.DepartmentApp.Labs.UseCases.Inventor_Lab;
using ERP.Application.DepartmentApp.Labs.Interfaces.Inventory_Lab;

namespace ERP.Application.DepartmentApp.Labs.DependancyInjection
{
    public static class LabServiceCollection
    {


        public static IServiceCollection AddLabServices(
             this IServiceCollection services)
        {

            services.AddScoped<IAddLabEquipmentUseCase, AddNewLabEquipmentUseCase>();
            services.AddScoped<IGetLabEquipmentListUseCase, GetLabEquipmentlistUseCase>();
            services.AddScoped<IDeleteLabEquipmentUseCase, DeleteLabEquipmentUseCase>();
            services.AddScoped<IEditLabEquimentUsecase, EditLabEquipmentUseCase>();
            services.AddScoped<IGetLabEquipmentByIdUseCase, GetLabEquipmentByIdUseCase>();



            return services;
        }
    }
}
