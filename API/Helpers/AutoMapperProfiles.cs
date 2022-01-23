using System;
using System.Linq;
using API.DTOs;
using API.Entities;
using AutoMapper;

namespace API.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<OrgDataDto,OrgData>();
            CreateMap<OrgData,OrgDataDto>();
        }
    }
}