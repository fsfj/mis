using System.Linq;
using System.Threading.Tasks;
using MIS.API.Models;

namespace MIS.API.Repositories
{
    public interface IMembersRepository
    {
         IQueryable<Member> GetAll();
         Task<Member> GetByMemberId(int id);
         Task CreateAsync(Member member);
         Task UpdateAsync(Member member);
         Task DeleteAsync(Member member);
    }
}