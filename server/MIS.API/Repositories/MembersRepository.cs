using System.Threading.Tasks;
using MIS.API.Data;
using MIS.API.Models;

namespace MIS.API.Repositories
{
    public class MembersRepository : GenericRepository<Member>, IMembersRepository
    {
        public MembersRepository(DataContext context) 
            : base(context)
        {
        }
        public async Task<Member> GetByMemberId(int id)
        {
            return await GetById(id);
        }
        public async Task CreateAsync(Member member)
        {
            Create(member);
            await SaveAsync();
        }

        public async Task DeleteAsync(Member member)
        {
           Delete(member);
           await SaveAsync();
        }

        public async Task UpdateAsync(Member member)
        {
            Update(member);
            await SaveAsync();
        }
    }
}