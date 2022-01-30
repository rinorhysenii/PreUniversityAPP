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
        public async Task<IActionResult> GetMyChilds(Guid prid)
        {
            var resault =await _parentRepository.GetMyChildren(prid);
            return Ok(resault);
        }
        [HttpGet("id")]
        public async Task<IActionResult> GetTrascriptForMyChild(Guid id)
        {
           var res= _parentRepository.GetTranskciptForMyChild(id);
            return Ok(res);
        }
        [HttpGet("/average/id")]
        public async Task<IActionResult> GetavgForMyChild(Guid id) 
        {
            var res = _parentRepository.GetAvgForMyChild(id);
            return Ok(res);
        }

    }
}
