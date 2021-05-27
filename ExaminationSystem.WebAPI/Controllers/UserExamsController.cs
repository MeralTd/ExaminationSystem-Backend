using ExaminationSystem.Business.Abstract;
using ExaminationSystem.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ExaminationSystem.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserExamsController : ControllerBase
    {
        IUserExamService _userExamService;
        public UserExamsController(IUserExamService userExamService)
        {
            _userExamService = userExamService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _userExamService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int userExamId)
        {
            var result = _userExamService.GetById(userExamId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(UserExam userExam)
        {
            var result = _userExamService.Add(userExam);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(UserExam userExam)
        {
            var result = _userExamService.Update(userExam);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(UserExam userExam)
        {
            var result = _userExamService.Delete(userExam);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
