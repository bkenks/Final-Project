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
    public class TableTwoController : ControllerBase
    {
        private readonly FinalContext context;

        private readonly ILogger<TableTwoController> _logger;

        public TableTwoController(ILogger<TableTwoController> logger, FinalContext _context)
        {
            _logger = logger;
            context = _context;
        }

        private TableTwo GetRowById(int id)
        {
            return context.TableTwo.Where(x => x.Id.Equals(id)).FirstOrDefault();
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(context.TableTwo.ToList());
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            var row = GetRowById(id);
            context.TableTwo.Remove(row);
            context.SaveChanges();
            return Ok(row);
        }

        [HttpPut]
        public IActionResult Put(TableTwo table)
        {
            var rowToUpdate = this.GetRowById(table.Id);

            rowToUpdate.FavoriteSong = table.FavoriteSong;
            rowToUpdate.Month = table.Month;
            rowToUpdate.NickName = table.NickName;
            rowToUpdate.Year = table.Year;

            context.TableTwo.Update(rowToUpdate);
            context.SaveChanges();

            return Ok(rowToUpdate);
        }

        [HttpPost]
        public IActionResult Post(TableTwo table)
        {
            context.TableTwo.Add(table);
            context.SaveChanges();
            return Ok(table);
        }
    }
}
