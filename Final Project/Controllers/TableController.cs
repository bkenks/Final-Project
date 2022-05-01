using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using Final_Project.Models.DataLayer;
using System.Threading.Tasks;
using NSwag;

namespace Final_Project.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class TableController : ControllerBase
    {
        private readonly FinalContext context;

        private readonly ILogger<TableController> _logger;

        public TableController(ILogger<TableController> logger, FinalContext _context)
        {
            _logger = logger;
            context = _context;
        }

        private Table GetRowById(int id)
        {
            return context.Table.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.Table.ToList());
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var row = GetRowById(id);
            context.Table.Remove(row);
            context.SaveChanges();
            return Ok(row);
        }

        [HttpPut]
        public IActionResult Put(Table table)
        {
            var rowToUpdate = this.GetRowById(table.Id);

            rowToUpdate.BadgeNumber = table.BadgeNumber;
            rowToUpdate.CardNumber = table.CardNumber;
            rowToUpdate.CurrentPhone = table.CurrentPhone;
            rowToUpdate.TimeOfDay = table.TimeOfDay;

            context.Table.Update(rowToUpdate);
            context.SaveChanges();

            return Ok(rowToUpdate);
        }

        [HttpPost]
        public IActionResult Post(Table table)
        {
            context.Table.Add(table);
            context.SaveChanges();
            return Ok(table);
        }
    }
}