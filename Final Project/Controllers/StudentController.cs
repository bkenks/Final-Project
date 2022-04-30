using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSwag;
using Final_Project.Models.DataLayer;
using System.Diagnostics;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class StudentController : ControllerBase
    {
        private FinalContext context = new FinalContext();

        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger, FinalContext _context)
        {
            _logger = logger;
            context = _context;
        }

        [HttpGet]
        public IActionResult Get()
        {
            Debug.WriteLine(context.Student.ToList());
            return Ok(context.Student.ToList());
        }

        //[HttpPut]
        //public IActionResult Put(Student student)
        //{
        //    //context.
        //}

        //[HttpPost]
        //public IActionResult Post(Student student)
        //{
        //    var result = context.Student.Add(student);
        //}
    }
}
