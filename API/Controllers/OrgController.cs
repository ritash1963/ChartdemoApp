using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using API.Data;
using API.Entities;
using AutoMapper;
using API.Interfaces;
using API.DTOs;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class OrgController : ControllerBase
    {
        private readonly IOrgRepository _repo;
        private readonly IMapper _mapper;
        public OrgController(IOrgRepository repo, IMapper mapper)
        {
            _repo = repo;
            _mapper = mapper;
        }

        [HttpPost]
        public async Task<ActionResult<List<OrgData>>> GetOrgData([FromBody] string orgName)
        {

            var orgDataDto = await _repo.GetOrgDataAsync(orgName);

            return Ok(orgDataDto);
        }

    }
}
