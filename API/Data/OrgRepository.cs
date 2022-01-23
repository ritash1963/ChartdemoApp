using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using API.DTOs;
using API.Entities;
using API.Interfaces;
using Microsoft.EntityFrameworkCore;
using AutoMapper;

namespace API.Data
{
    public class OrgRepository : IOrgRepository
    {
        private readonly DataContext _context;
        private readonly IMapper _mapper;
        public OrgRepository(DataContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

     
        public async Task<List<OrgDataDto>> GetOrgDataAsync(string orgName)
        {
            var orgData  = await _context.OrgDataTb.Where(x => x.OrgName == orgName).ToListAsync();
            var orgDataDto = _mapper.Map<List<OrgDataDto>>(orgData);
            return orgDataDto;
        }
     
    }
}