using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MIS.API.Dtos;

namespace MIS.API.Services
{
    public interface IMembersService
    {
         Task<IEnumerable<MemberDto>> GetAllMembers();
         Task Create(MemberDto memberDto);
         Task Update(int id, MemberDto memberDto);
         Task Delete(int id);
         Task<MemberDto> GetMemberById(int id);
        
         
    }
}