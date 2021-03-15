﻿using API.Data_Models.Dtos;
using API.Dtos;
using API.Models;
using AutoMapper;
using Remuner8_Backend.Dtos;
using Remuner8_Backend.EntityModels;
using Remuner8_Backend.Models;

namespace API.Profiles
{
    public class AutomapperProfile : Profile
    {
        public AutomapperProfile()
        {
            CreateMap<Password, PasswordReadDto>().ReverseMap();
            CreateMap<TimeSheet, TimeSheetDto>().ReverseMap();
            CreateMap<PasswordCreateDto, Password>().ReverseMap();
            CreateMap<PayrollAdditionItemCreateDto, PayrollAdditionItem>().ReverseMap();
            CreateMap<PayrollAdditionItem, PayrollAdditionItemReadDto>().ReverseMap();
            CreateMap<LeaveTypeCreateDto, LeaveType>().ReverseMap();
            CreateMap<LeaveType, LeaveTypeReadDto>().ReverseMap();
            CreateMap<PayrollDeductionItem, PayrollDeductionItemReadDto>();
            CreateMap<PayrollDeductionItem, PayrollDeductionItemCreateDto>().ReverseMap();
            CreateMap<PayrollOvertimeItem, PayrollOvertimeItemCreateDto>().ReverseMap();
            CreateMap<PayrollOvertimeItem, PayrollOvertimeItemReadDto>().ReverseMap();
        }
    }
}