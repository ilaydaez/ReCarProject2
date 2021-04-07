using Business.Abstract;
using Entities.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FindexController : ControllerBase
    {
        IFindexService _findexService;
        public FindexController(IFindexService findexService)
        {
            _findexService = findexService;
        }
        [HttpPost("add")]
        public IActionResult Add(Findex findex)
        {
            var result = _findexService.Add(findex);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("update")]
        public IActionResult Update(Findex findex)
        {
            var result = _findexService.Update(findex);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpPost("delete")]
        public IActionResult Delete(Findex findex)
        {
            var result = _findexService.Delete(findex);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyid")]
        public IActionResult GetById(int id)
        {
            var result = _findexService.GetById(id);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }
        [HttpGet("getbyuserid")]
        public IActionResult GetByUserId(int userId)
        {
            var result = _findexService.GetByUserId(userId);
            if (result.Success)
            {
                return Ok(result);

            }
            return BadRequest(result);
        }


    }
}

