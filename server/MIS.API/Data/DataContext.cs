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
            optionsBuilder.UseSqlServer(@"Server=10.100.0.43; Database=MISDB; User=sa; Password=ansidev2016@!#;");
            //optionsBuilder.UseMySql(@"server=172.17.0.1;user=root;password=Adminroot123!;database=misdb");
        }
        private DbSet<Member> Members { get; set; }
    }
}