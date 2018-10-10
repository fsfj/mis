using System.ComponentModel.DataAnnotations;

namespace MIS.API.Models
{
    public class CellLeader
    {
        [Key]
        public int Id { get; set; }
        public Member Member { get; set; }
        public int MemberId { get; set; }
    }
}