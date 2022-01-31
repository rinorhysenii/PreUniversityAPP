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

        [HttpGet("getMyChilds/{parentId}")]
        public async Task<IActionResult> GetMyChilds(Guid parentId)
        {
            var resault =await _parentRepository.GetMyChildren(parentId);
            return Ok(resault);
        }

        [HttpGet("getTrascriptForMyChild/{studentid}")]
        public async Task<IActionResult> GetTrascriptForMyChild(Guid studentid)
        {
           var res= await _parentRepository.GetTranskciptForMyChild(studentid);
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
