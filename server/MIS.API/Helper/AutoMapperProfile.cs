using AutoMapper;
using MIS.API.Dtos;
using MIS.API.Models;
namespace MIS.API.Helper
{
    public class AutoMapperProfile: Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<MemberDto, Member>();   
        }
    }
}