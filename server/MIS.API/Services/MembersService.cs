using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.EntityFrameworkCore;
using MIS.API.Dtos;
using MIS.API.Models;
using MIS.API.Repositories;

namespace MIS.API.Services
{
    public class MembersService : IMembersService
    {
        private readonly IMapper mapper;
        private readonly IMembersRepository repo;
        public MembersService(IMapper mapper,
            IMembersRepository repo)
        {
            this.mapper = mapper;
            this.repo = repo;
        }

        public async Task Create(MemberDto memberDto)
        {
            var newMember = mapper.Map<Member>(memberDto);

            await repo.CreateAsync(newMember);
        }

        public async Task Delete(int id)
        {
            var member = await repo.GetByMemberId(id);
            if(member != null)
                await repo.DeleteAsync(member);
        }

        public async Task<IEnumerable<MemberDto>> GetAllMembers()
        {
            var members = await repo.GetAll().ToListAsync();

            var membersDto = mapper.Map<List<MemberDto>>(members);

            return membersDto;
        }

        public async Task<MemberDto> GetMemberById(int id)
        {
            var memberDto = mapper.Map<MemberDto>(await repo.GetByMemberId(id));
            return memberDto;
        }

        public async Task Update(int id, MemberDto memberDto)
        {
            var updateMember = mapper.Map<Member>(memberDto);
            //var member = await repo.GetByMemberId(id);
            if(updateMember != null)
                await repo.UpdateAsync(updateMember);
        }
    }
}