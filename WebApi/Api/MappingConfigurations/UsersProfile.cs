using Api.Core.Domain;
using Api.Model;
using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.MappingConfigurations
{
    public class UsersProfile : Profile
    {
        public UsersProfile()
        {
            CreateMap<AddUserViewModel, MasterMember>().ReverseMap();
        }
    }
}
