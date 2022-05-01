using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using NSwag;
using Final_Project.Models.DataLayer;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableOneController : ControllerBase
    {
        private readonly FinalContext context;

        private readonly ILogger<TableOneController> _logger;

        public TableOneController(ILogger<TableOneController> logger, FinalContext _context)
        {
            _logger = logger;
            context = _context;
        }

        private TableOne GetRowById(int id)
        {
            return context.TableOne.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.TableOne.ToList());
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var row = GetRowById(id);
            context.TableOne.Remove(row);
            context.SaveChanges();
            return Ok(row);
        }

        [HttpPut]
        public IActionResult Put(TableOne table)
        {
            var rowToUpdate = this.GetRowById(table.Id);

            rowToUpdate.FavoriteBreakfast = table.FavoriteBreakfast;
            rowToUpdate.FavoriteDay = table.FavoriteDay;
            rowToUpdate.Hobby = table.Hobby;
            rowToUpdate.MiddleName = table.MiddleName;

            context.TableOne.Update(rowToUpdate);
            context.SaveChanges();

            return Ok(rowToUpdate);
        }

        [HttpPost]
        public IActionResult Post(TableOne table)
        {
            context.TableOne.Add(table);
            context.SaveChanges();
            return Ok(table);
        }
    }
}
