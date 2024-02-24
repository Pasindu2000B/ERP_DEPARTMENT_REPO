﻿// <auto-generated />
using System;
using ERP.Repository.PgSql;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace ERP.Repository.PgSql.Migrations
{
    [DbContext(typeof(PgSqlDbContext))]
    [Migration("20240223134936_xx")]
    partial class xx
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("ERP.Domain.Core.Entity.DepartmentEntity.GraduatesEntity.Graduate", b =>
                {
                    b.Property<int>("GraduateID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("GraduateID"));

                    b.Property<string>("GraduateCompany")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GraduateContactNo")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GraduateDescription")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("GraduateName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("GraduateID");

                    b.ToTable("Graduates");

                    b.HasData(
                        new
                        {
                            GraduateID = 1001,
                            GraduateCompany = "350 Kessler Key, Gulgowskibury, Faroe Islands",
                            GraduateContactNo = "1-835-460-4979",
                            GraduateDescription = "Future",
                            GraduateName = "Guido"
                        },
                        new
                        {
                            GraduateID = 1002,
                            GraduateCompany = "9066 Block Valleys, East Carrollhaven, Serbia",
                            GraduateContactNo = "1-831-290-7649 x430",
                            GraduateDescription = "Dynamic",
                            GraduateName = "Aron"
                        },
                        new
                        {
                            GraduateID = 1003,
                            GraduateCompany = "0410 Fritsch Neck, Lake Geneville, Georgia",
                            GraduateContactNo = "1-847-800-3095",
                            GraduateDescription = "National",
                            GraduateName = "Stanton"
                        });
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.LabEquipment", b =>
                {
                    b.Property<int>("LabEquipmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LabEquipmentID"));

                    b.Property<bool>("Avaialability")
                        .HasColumnType("boolean");

                    b.Property<string>("LabEquipmentName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("LabSpaceId")
                        .HasColumnType("integer");

                    b.Property<string>("condition")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LabEquipmentID");

                    b.ToTable("LabEquipments");

                    b.HasData(
                        new
                        {
                            LabEquipmentID = 1001,
                            Avaialability = false,
                            LabEquipmentName = "Sherwood",
                            LabSpaceId = 0,
                            condition = "bad"
                        },
                        new
                        {
                            LabEquipmentID = 1002,
                            Avaialability = false,
                            LabEquipmentName = "Jean",
                            LabSpaceId = 0,
                            condition = "bad"
                        },
                        new
                        {
                            LabEquipmentID = 1003,
                            Avaialability = false,
                            LabEquipmentName = "Kendrick",
                            LabSpaceId = 0,
                            condition = "medium"
                        });
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.DepartmentEntity.LabEntity.LabSpace", b =>
                {
                    b.Property<int>("LabSpaceId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("LabSpaceId"));

                    b.Property<string>("LabSpaceName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("LabSpaceId");

                    b.ToTable("LabSpaces");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.StudentRequest", b =>
                {
                    b.Property<int>("RequestId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("RequestId"));

                    b.Property<string>("CompanyName")
                        .HasColumnType("text");

                    b.Property<string>("CompanySendersDesignation")
                        .HasColumnType("text");

                    b.Property<string>("CompanySendersName")
                        .HasColumnType("text");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("RequestId");

                    b.HasIndex("StudentId")
                        .IsUnique();

                    b.ToTable("StudentRequests");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Batch", b =>
                {
                    b.Property<int>("BatchId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("BatchId"));

                    b.Property<string>("BatchName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("StartDate")
                        .HasColumnType("date");

                    b.HasKey("BatchId");

                    b.ToTable("Batch");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Curriculum", b =>
                {
                    b.Property<int>("CurriculumId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("CurriculumId"));

                    b.Property<int?>("DegreeId")
                        .HasColumnType("integer");

                    b.HasKey("CurriculumId");

                    b.HasIndex("DegreeId");

                    b.ToTable("Curriculum");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Degree", b =>
                {
                    b.Property<int>("DegreeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DegreeId"));

                    b.Property<string>("DegreeName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("DepartmentId")
                        .HasColumnType("integer");

                    b.HasKey("DegreeId");

                    b.HasIndex("DepartmentId");

                    b.ToTable("Degree");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Department", b =>
                {
                    b.Property<int>("DepartmentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("DepartmentId"));

                    b.HasKey("DepartmentId");

                    b.ToTable("Department");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Evaluation", b =>
                {
                    b.Property<int>("EvaluationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("EvaluationId"));

                    b.Property<double>("FinalMarks")
                        .HasColumnType("double precision");

                    b.Property<double>("Marks")
                        .HasColumnType("double precision");

                    b.Property<int?>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("TotalMarks")
                        .HasColumnType("integer");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("EvaluationId");

                    b.HasIndex("ModuleOfferingId");

                    b.ToTable("Evaluation");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Module", b =>
                {
                    b.Property<int>("ModuleId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleId"));

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Credits")
                        .HasColumnType("integer");

                    b.Property<int?>("CurriculumId")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Semester")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Type")
                        .HasColumnType("integer");

                    b.HasKey("ModuleId");

                    b.HasIndex("CurriculumId");

                    b.ToTable("Modules");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleOfferingId"));

                    b.Property<int>("CoordinatorTeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("ExternalModeratorTeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("ModeratorTeacherId")
                        .HasColumnType("integer");

                    b.Property<int>("ModuleId")
                        .HasColumnType("integer");

                    b.Property<int>("SemesterId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId");

                    b.HasIndex("CoordinatorTeacherId");

                    b.HasIndex("ExternalModeratorTeacherId");

                    b.HasIndex("ModeratorTeacherId");

                    b.HasIndex("ModuleId");

                    b.HasIndex("SemesterId");

                    b.ToTable("ModuleOffering");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOfferingFirstExaminer", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ModuleFirstExaminers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOfferingSecondExaminer", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ModuleSecondExaminers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOfferingTeacher", b =>
                {
                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("TeacherId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleOfferingId", "TeacherId");

                    b.HasIndex("TeacherId");

                    b.ToTable("ModuleTeachers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleRegistration", b =>
                {
                    b.Property<int>("ModuleRegistrationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("ModuleRegistrationId"));

                    b.Property<int>("ModuleOfferingId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("ModuleRegistrationId");

                    b.HasIndex("ModuleOfferingId");

                    b.HasIndex("StudentId");

                    b.ToTable("ModuleRegistration");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Semester", b =>
                {
                    b.Property<int>("SemesterId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("SemesterId"));

                    b.Property<int>("BatchId")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("EndDate")
                        .HasColumnType("date");

                    b.Property<string>("SemesterName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("SpecializationDegreeId")
                        .HasColumnType("integer");

                    b.Property<DateOnly?>("StartDate")
                        .HasColumnType("date");

                    b.Property<int?>("StudentId")
                        .HasColumnType("integer");

                    b.HasKey("SemesterId");

                    b.HasIndex("BatchId");

                    b.HasIndex("SpecializationDegreeId");

                    b.HasIndex("StudentId");

                    b.ToTable("Semester");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Student", b =>
                {
                    b.Property<int>("StudentId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentId"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int?>("DegreeId")
                        .HasColumnType("integer");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DoB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<double>("GPA")
                        .HasColumnType("double precision");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("RegistrationNum")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("StudentId");

                    b.HasIndex("DegreeId");

                    b.ToTable("Students");

                    b.HasData(
                        new
                        {
                            StudentId = 1001,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Ansley27@yahoo.com",
                            FirstName = "Ansley",
                            GPA = 0.0,
                            LastName = "Boyle",
                            NationalID = "",
                            Phone = "",
                            PhoneNumber = "",
                            RegistrationNum = "EG/2020/1629"
                        },
                        new
                        {
                            StudentId = 1002,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Mya.Wehner87@hotmail.com",
                            FirstName = "Mya",
                            GPA = 0.0,
                            LastName = "Wehner",
                            NationalID = "",
                            Phone = "",
                            PhoneNumber = "",
                            RegistrationNum = "EG/2020/3444"
                        },
                        new
                        {
                            StudentId = 1003,
                            Address1 = "",
                            Address2 = "",
                            City = "",
                            District = "",
                            DoB = new DateOnly(1, 1, 1),
                            Email = "Eliane_Kerluke@hotmail.com",
                            FirstName = "Eliane",
                            GPA = 0.0,
                            LastName = "Kerluke",
                            NationalID = "",
                            Phone = "",
                            PhoneNumber = "",
                            RegistrationNum = "EG/2022/9307"
                        });
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.StudentResult", b =>
                {
                    b.Property<int>("StudentResultId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("StudentResultId"));

                    b.Property<int?>("EvaluationId")
                        .HasColumnType("integer");

                    b.Property<int>("StudentId")
                        .HasColumnType("integer");

                    b.Property<double>("StudentScore")
                        .HasColumnType("double precision");

                    b.HasKey("StudentResultId");

                    b.HasIndex("EvaluationId");

                    b.HasIndex("StudentId");

                    b.ToTable("StudentResult");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Teacher", b =>
                {
                    b.Property<int>("TeacherId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("TeacherId"));

                    b.Property<string>("Address1")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Address2")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("District")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<DateOnly>("DoB")
                        .HasColumnType("date");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("NationalID")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("TeacherId");

                    b.ToTable("Teachers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.StudentRequest", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Student", null)
                        .WithOne("studentRequest")
                        .HasForeignKey("ERP.Domain.Core.Entity.DepartmentEntity.TrainingEntity.StudentRequest", "StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Curriculum", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Degree", null)
                        .WithMany("Curricula")
                        .HasForeignKey("DegreeId");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Degree", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Department", "Department")
                        .WithMany()
                        .HasForeignKey("DepartmentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Evaluation", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", null)
                        .WithMany("Evalutions")
                        .HasForeignKey("ModuleOfferingId");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Module", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Curriculum", null)
                        .WithMany("Modules")
                        .HasForeignKey("CurriculumId");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Teacher", "Coordinator")
                        .WithMany("CordinatingModules")
                        .HasForeignKey("CoordinatorTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Teacher", "ExternalModerator")
                        .WithMany()
                        .HasForeignKey("ExternalModeratorTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Teacher", "Moderator")
                        .WithMany()
                        .HasForeignKey("ModeratorTeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Module", "Module")
                        .WithMany()
                        .HasForeignKey("ModuleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Semester", "Semester")
                        .WithMany("Modules")
                        .HasForeignKey("SemesterId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Coordinator");

                    b.Navigation("ExternalModerator");

                    b.Navigation("Moderator");

                    b.Navigation("Module");

                    b.Navigation("Semester");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOfferingFirstExaminer", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", "ModuleOffering")
                        .WithMany("FirstExaminers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Teacher", "Teacher")
                        .WithMany("FirstExaminersModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleOffering");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOfferingSecondExaminer", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", "ModuleOffering")
                        .WithMany("SecondExaminers")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Teacher", "Teacher")
                        .WithMany("SecondExaminersModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleOffering");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOfferingTeacher", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", "ModuleOffering")
                        .WithMany("Teachers")
                        .HasForeignKey("ModuleOfferingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Teacher", "Teacher")
                        .WithMany("TeachingModules")
                        .HasForeignKey("TeacherId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("ModuleOffering");

                    b.Navigation("Teacher");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleRegistration", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", "Module")
                        .WithMany("Registrations")
                        .HasForeignKey("ModuleOfferingId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Module");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Semester", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Batch", "Batch")
                        .WithMany()
                        .HasForeignKey("BatchId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Degree", "Specialization")
                        .WithMany()
                        .HasForeignKey("SpecializationDegreeId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Student", null)
                        .WithMany("Semesters")
                        .HasForeignKey("StudentId");

                    b.Navigation("Batch");

                    b.Navigation("Specialization");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Student", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Degree", "Degree")
                        .WithMany()
                        .HasForeignKey("DegreeId");

                    b.Navigation("Degree");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.StudentResult", b =>
                {
                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Evaluation", null)
                        .WithMany("Results")
                        .HasForeignKey("EvaluationId");

                    b.HasOne("ERP.Domain.Core.Entity.StudentEntity.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Student");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Curriculum", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Degree", b =>
                {
                    b.Navigation("Curricula");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Evaluation", b =>
                {
                    b.Navigation("Results");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.ModuleOffering", b =>
                {
                    b.Navigation("Evalutions");

                    b.Navigation("FirstExaminers");

                    b.Navigation("Registrations");

                    b.Navigation("SecondExaminers");

                    b.Navigation("Teachers");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Semester", b =>
                {
                    b.Navigation("Modules");
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Student", b =>
                {
                    b.Navigation("Semesters");

                    b.Navigation("studentRequest")
                        .IsRequired();
                });

            modelBuilder.Entity("ERP.Domain.Core.Entity.StudentEntity.Teacher", b =>
                {
                    b.Navigation("CordinatingModules");

                    b.Navigation("FirstExaminersModules");

                    b.Navigation("SecondExaminersModules");

                    b.Navigation("TeachingModules");
                });
#pragma warning restore 612, 618
        }
    }
}
