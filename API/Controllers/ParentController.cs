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

        [HttpGet("getMyChilds/{id}")]
        public async Task<IActionResult> GetMyChilds(Guid prid)
        {
            var resault =await _parentRepository.GetMyChildren(prid);
            return Ok(resault);
        }

        [HttpGet("getTrascriptForMyChild/{id}")]
        public async Task<IActionResult> GetTrascriptForMyChild(Guid id)
        {
           var res= await _parentRepository.GetTranskciptForMyChild(id);
            return Ok(res);
        }

        [HttpGet("getAvgForMyChild/{id}")]
        public IActionResult GetAvgForMyChild(Guid id) 
        {
            var res = _parentRepository.GetAvgForMyChild(id);
            return Ok(res);
        }

    }
}
