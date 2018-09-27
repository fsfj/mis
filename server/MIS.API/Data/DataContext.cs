using Microsoft.EntityFrameworkCore;
using MIS.API.Models;

namespace MIS.API.Data
{
    public class DataContext: DbContext
    {
        public DataContext(DbContextOptions<DataContext> options)
            :base(options)
        {
            
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql(@"server=localhost;user=root;password=Adminroot123!;database=misdb");
        }
        private DbSet<Member> Members { get; set; }
    }
}