using System;
using MIS.API.Enums;

namespace MIS.API.Dtos
{
    public class MemberDto
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Middlename { get; set; }
        public string Lastname { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string ContactNumber { get; set; }
        public string Address { get; set; }
        public KapisananEnum Kapisanan { get; set; }

        public string Name 
        { 
            get 
            {
                return string.Format("{0} {1} {2}", Firstname, Middlename, Lastname);
            }
        }
    }
}