using ERP.Application.DepartmentApp.Labs.Repository;

using ERP.Application.StudentApp.Interfaces;
using ERP.Application.StudentApp.Students;
using ERP.Application.StudentApp.Students.Interfaces;
using ERP.BlazorUI.Components;
using ERP.Repository.InMemory;
using ERP.Repository.PgSql;
using ERP.Repository.SQLite;
using Microsoft.EntityFrameworkCore;

using MudBlazor.Services;
using ERP.Repository.PgSql.Department.Lab;
using ERP.Application.DepartmentApp.Labs.UseCases.Inventor_Lab;
using ERP.Application.DepartmentApp.Labs.Interfaces.Inventory_Lab;
using ERP.Application.DepartmentApp.Graduates.Repository;
using ERP.Repository.PgSql.Department.Graduate;
using ERP.Application.DepartmentApp.Graduates.Interfaces;
using ERP.Application.DepartmentApp.Graduates.UseCases;
using ERP.Application.DepartmentApp.Training.Interfaces;
using ERP.Application.DepartmentApp.Training.Usecases;
using ERP.Application.DepartmentApp.Training;
using ERP.Repository.PgSql.Department.Training;
using MudBlazor;
using NuGet.Protocol.Core.Types;
using ERP.Application.DepartmentApp.Recruiments.Interfaces;
using ERP.Application.DepartmentApp.Recruiments.UseCases;
using ERP.Application.DepartmentApp.Recruiments;
using ERP.Repository.PgSql.Department.Recruiment;
using Syncfusion.Blazor;
using ERP.Application.DepartmentApp.Labs.Interfaces.Scheduling_Lab;
using ERP.Application.DepartmentApp.Labs.UseCases.Scheduling_Lab;

var builder = WebApplication.CreateBuilder(args);

// Configuration of EF Core SQLite
ConfigurationManager configuration = builder.Configuration;

//builder.Services.AddDbContext<BaseDbContext>(opt => opt.UseSqlite(configuration.GetConnectionString("StudentDatabase"),
//     b => b.MigrationsAssembly("ERP.Repository.SQLite")));

builder.Services.AddMudServices(config =>
{
    config.SnackbarConfiguration.PositionClass = Defaults.Classes.Position.BottomRight;

    config.SnackbarConfiguration.PreventDuplicates = false;
    config.SnackbarConfiguration.NewestOnTop = false;
    config.SnackbarConfiguration.ShowCloseIcon = true;
    config.SnackbarConfiguration.VisibleStateDuration = 2500;
    config.SnackbarConfiguration.HideTransitionDuration = 500;
    config.SnackbarConfiguration.ShowTransitionDuration = 500;
    config.SnackbarConfiguration.SnackbarVariant = Variant.Filled;
});



builder.Services.AddDbContextFactory<PgSqlDbContext>(opt =>
{
    opt.UseNpgsql(configuration.GetConnectionString("PgSqlConnection"),
        b => b.MigrationsAssembly("ERP.Repository.PgSql"));

    if (builder.Environment.IsDevelopment())
    {
        // Enable sensitive data logging only in development environment
        opt.EnableSensitiveDataLogging();
    }
});


// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

builder.Services.AddMudServices();


builder.Services.AddScoped<IStudentRepository, StudentRepositoryPgSql>();
builder.Services.AddScoped<ILabRepository,LabRepositoryPgSql>();
builder.Services.AddScoped<IGraduateRepository, GraduateRepositoryPgSql>();
builder.Services.AddScoped<ITrainingRepository, TraininiRepositoryPgSQL>();
builder.Services.AddScoped<IRecrumentRepository,RecruimentRepositoryPgSQL>();



builder.Services.AddScoped<IGetLabEquipmentListUseCase, GetLabEquipmentlistUseCase>();
builder.Services.AddScoped<IViewStudentsByNameUseCase, ViewStudentsByNameUseCase>();
builder.Services.AddScoped<IAddStudentUseCase, AddStudentUseCase>();
builder.Services.AddScoped<IViewStudentById, ViewStudentById>();
builder.Services.AddScoped<IEditStudentUseCase, EditStudentUseCase>();
builder.Services.AddScoped<IAddLabEquipmentUseCase,AddNewLabEquipmentUseCase>();
builder.Services.AddScoped<IAddGraduateUseCase, AddGraduateUseCase>();
builder.Services.AddScoped<IStudentRequestCreateUseCase,StudentRequestUseCase>();
builder.Services.AddScoped<IGetGraduateListUseCase, GetGraduateListUseCase>();
builder.Services.AddScoped<IEditGraduateUseCase, EditGraduateUseCase>();
builder.Services.AddScoped<IDeleteGraduateUseCase, DeleteGraduateUseCase>();

builder.Services.AddScoped<IGetGraduateListByCompanyUseCase, GetGraduateListByCompanyUseCase>();
builder.Services.AddScoped<IGetAllCompanyNamesUseCase, GetAllCompanyNamesUseCase>();   
builder.Services.AddScoped<IGetTrainingRequests,GetTrainingRequests>();
builder.Services.AddScoped<IRecruimentCrudUseCase,CRUDRecrumentUseCase>();

builder.Services.AddScoped<IGetGraduateListByCompanyUseCase, GetGraduateListByCompanyUseCase>();
builder.Services.AddScoped<IGetAllCompanyNamesUseCase, GetAllCompanyNamesUseCase>();   
builder.Services.AddScoped<IGetTrainingRequests,GetTrainingRequests>();

builder.Services.AddScoped<IInternPostUseCase,InternPostUseCasecs>();
builder.Services.AddScoped<IInternPostViewUseCase, InternViewUseCase>();

builder.Services.AddSyncfusionBlazor();
builder.Services.AddScoped<IFileUploadUseCase, FileUploadUseCase>();
builder.Services.AddScoped<IEditLabEquimentUsecase, EditLabEquipmentUseCase>();
builder.Services.AddScoped<IGetLabEquipmentByIdUseCase, GetLabEquipmentByIdUseCase>();
builder.Services.AddScoped<IGetLabEquipmentListUseCase, GetLabEquipmentlistUseCase>();
builder.Services.AddScoped<IDeleteLabEquipmentUseCase, DeleteLabEquipmentUseCase>();
builder.Services.AddScoped<IGetScheduleLabUseCase, GetScheduledLab>();
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
   
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();


/*
 * using Syncfusion.Blazor;
....
builder.Services.AddSyncfusionBlazor();
 * */