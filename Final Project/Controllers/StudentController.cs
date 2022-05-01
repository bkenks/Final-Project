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
        private readonly FinalContext context;

        private readonly ILogger<StudentController> _logger;

        public StudentController(ILogger<StudentController> logger, FinalContext _context)
        {
            _logger = logger;
            context = _context;
        }

        private Student GetRowById(int id)
        {
            return context.Student.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Student.ToList());
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var row = GetRowById(id);
            context.Student.Remove(row);
            context.SaveChanges();
            return Ok(row);
        }

        [HttpPut]
        public IActionResult Put(Student student)
        {
            var rowToUpdate = this.GetRowById(student.Id);

            rowToUpdate.FirstName = student.FirstName;
            rowToUpdate.LastName = student.LastName;
            rowToUpdate.Program = student.Program;
            rowToUpdate.Birthday = student.Birthday;
            rowToUpdate.Year = student.Year;

            context.Student.Update(rowToUpdate);
            context.SaveChanges();

            return Ok(rowToUpdate);
        }

        [HttpPost]
        public IActionResult Post(Student student)
        {
            context.Student.Add(student);
            context.SaveChanges();
            return Ok(student);
        }
    }
}