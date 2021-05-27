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
    public class ChoicesController : ControllerBase
    {
        IChoiceService _choiceService;
        public ChoicesController(IChoiceService choiceService)
        {
            _choiceService = choiceService;
        }

        [HttpGet("getall")]
        public IActionResult GetAll()
        {
            var result = _choiceService.GetAll();
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult GetById(int choiceId)
        {
            var result = _choiceService.GetById(choiceId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

         [HttpGet("getbyquestionid")]
        public IActionResult GetByQuestionId(int questionId)
        {
            var result = _choiceService.GetByQuestionId(questionId);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(Choice choice)
        {
            var result = _choiceService.Add(choice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("update")]
        public IActionResult Update(Choice choice)
        {
            var result = _choiceService.Update(choice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }

        [HttpPost("delete")]
        public IActionResult Delete(Choice choice)
        {
            var result = _choiceService.Delete(choice);
            if (result.Success)
            {
                return Ok(result);
            }
            return BadRequest(result);
        }
    }
}
