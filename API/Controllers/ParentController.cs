using Application.Interfaces;
using Application.Repositories;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
   
    public class ParentController : ControllerBase
    {
        public readonly IParentRepository _parentRepository;
        public ParentController(IParentRepository parentRepository)
        {
            _parentRepository = parentRepository;
        }
        [HttpGet]
        public async Task<IActionResult> getMyChilds(Guid prid)
        {
            var resault =await _parentRepository.getMyChildren(prid);
            return Ok(resault);
        }
        [HttpGet("id")]
        public async Task<IActionResult> getTrascriptForMyChild(Guid id)
        {
           var res= _parentRepository.getTranskciptForMyChild(id);
            return Ok(res);
        }
        [HttpGet("/average/id")]
        public async Task<IActionResult> getavgForMyChild(Guid id)
        {
            var res = _parentRepository.getAvgForMyChild(id);
            return Ok(res);
        }

    }
}
