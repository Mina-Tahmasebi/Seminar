using SeminarMnagamenet.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeminarManagement.Database.EFCore;

namespace SeminarManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ConfrenceRomeContoroler : Controller
    {
        private AppDbContext _dbContext;

        public ConfrenceRomeContoroler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _dbContext.ConfrenceRomes.ToList();

                return Ok(result);
            }
            catch
            {
                return StatusCode(505);
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var result = _dbContext.ConfrenceRomes.FirstOrDefault(p => p.Id == id);

                return Ok(result);
            }
            catch
            {
                return StatusCode(505);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] ConfrenceRome confrenceRome)
        {
            try
            {
                var result = _dbContext.ConfrenceRomes.Add(confrenceRome);
                _dbContext.SaveChanges();

                return Ok(result);
            }
            catch
            {
                return StatusCode(505);
            }
        }

    }
}
