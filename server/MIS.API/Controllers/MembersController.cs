using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MIS.API.Dtos;
using MIS.API.Repositories;
using MIS.API.Services;

namespace MIS.API.Controllers
{
    [ApiController]
    [Route("api/members")]
    public class MembersController: ControllerBase
    {
        private readonly IMembersService service;
        public MembersController(IMembersService service)
        {
            this.service = service;
        }
        [HttpGet]
        public async Task<IActionResult> GetAllMembers()
        {
            return Ok(await service.GetAllMembers());
        }
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMemberById(int id)
        {
            return Ok(await service.GetMemberById(id));
        }
        [HttpPost]
        public async Task<IActionResult> Create(MemberDto memberDto)
        {
            await service.Create(memberDto);
            return Ok();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(int id, MemberDto memberDto)
        {
            await service.Update(id, memberDto);
            return Ok();
        }
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            await service.Delete(id);
            return Ok();
        }
    }
}