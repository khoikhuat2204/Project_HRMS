﻿using AutoMapper;
using HumanResourceApi.DTO.Allowance;
using HumanResourceApi.DTO.Attendance;
using HumanResourceApi.DTO.Deduction;
using HumanResourceApi.DTO.DeductionSummary;
using HumanResourceApi.DTO.Department;
using HumanResourceApi.DTO.DepartmentMemberList;
using HumanResourceApi.DTO.Employee;
using HumanResourceApi.DTO.EmployeeContract;
using HumanResourceApi.DTO.EmployeeLoanLog;
using HumanResourceApi.DTO.Experience;
using HumanResourceApi.DTO.Job;
using HumanResourceApi.DTO.Leave;
using HumanResourceApi.DTO.Project;
using HumanResourceApi.DTO.Skill;
using HumanResourceApi.DTO.SkillEmployee;
using HumanResourceApi.DTO.Users;
using HumanResourceApi.Models;

namespace HumanResourceApi.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<User, UserDto>()
                .ReverseMap();
            CreateMap<User, ResponseUserDto>()
                .ForMember(dest => dest.RoleName, opt => opt.MapFrom(src => src.Role.RoleName));
            CreateMap<User, UpdateUserDto>()
                .ReverseMap();
            CreateMap<Experience, ExperienceDto>()
                .ReverseMap();
            CreateMap<Experience, UpdateExperienceDto>()
                .ReverseMap();
            CreateMap<Leave, LeaveDto>()
                .ReverseMap();
            CreateMap<Leave, UpdateLeaveDto>()
                .ReverseMap();
            CreateMap<Job, JobDto>()
                .ReverseMap();
            CreateMap<Job, UpdateJobDto>()
                .ReverseMap();
            CreateMap<Allowance, AllowanceDto>()
                .ReverseMap();
            CreateMap<Allowance, UpdateAllowanceDto>()
                .ReverseMap();
            CreateMap<Attendance, AttendanceDto>()
                .ReverseMap();
            CreateMap<Attendance, UpdateAttendanceDto>()
                .ReverseMap();
            CreateMap<Department, DepartmentDto>()
                .ReverseMap();
            CreateMap<Department, UpdateDepartmentDto>()
                .ReverseMap();
            CreateMap<EmployeeContract, EmployeeContractDto>()
                .ReverseMap();
            CreateMap<EmployeeContract, UpdateEmployeeContractDto>()
                .ReverseMap();
            CreateMap<Employee, EmployeeDto>()
                .ReverseMap();
            CreateMap<Employee, UpdateEmployeeDto>()
                .ReverseMap();
            CreateMap<Skill, SkillDto>()
                .ReverseMap();
            CreateMap<Skill, UpdateSkillDto>()
                .ReverseMap();
            CreateMap<SkillEmployee, SkillEmployeeDto>()
                .ReverseMap();
            CreateMap<SkillEmployee, UpdateSkillEmployeeDto>()
                .ReverseMap();
            CreateMap<Deduction, DeductionDto>()
                .ReverseMap();
            CreateMap<Deduction, UpdateDeductionDto>()
                .ReverseMap();
            CreateMap<DeductionSumary, DeductionSumaryDto>()
                .ReverseMap();
            CreateMap<DeductionSumary, UpdateDeductionSumaryDto>()
                .ReverseMap();
            CreateMap<DepartmentMemberList, DepartmentMemberDto>()
                .ReverseMap();
            CreateMap<DepartmentMemberList, UpdateDepartmentMemberDto>()
                .ReverseMap();
            CreateMap<Project, ProjectDto>()
                .ReverseMap();
            CreateMap<Project, UpdateProjectDto>()
                .ReverseMap();
            CreateMap<EmployeeLoanLog, LoanLogDto>()
                .ReverseMap();
            CreateMap<EmployeeLoanLog, UpdateLoanLogDto>()
                .ReverseMap();
        }
    }
}
