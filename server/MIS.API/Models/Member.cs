using System;
using System.ComponentModel.DataAnnotations;
using MIS.API.Enums;

namespace MIS.API.Models
{
    public class Member
    {
        [Key]
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public KapisananEnum Kapisanan { get; set; }

        //public CellLeader CellLeader { get; set; }
    }
}