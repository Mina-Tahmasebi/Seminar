using Microsoft.AspNetCore.Mvc;
using SeminarManagement.Database.EFCore;
using SeminarMnagamenet.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace SeminarManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SeminarController : Controller
    {
        private AppDbContext _dbContext;

        public SeminarController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _dbContext.Seminars.ToList();

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
                var result = _dbContext.Seminars.FirstOrDefault(p => p.Id == id);

                return Ok(result);
            }
            catch
            {
                return StatusCode(505);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] Seminar seminar)
        {
            try
            {
                seminar.Lecturs = new List<Lectur>();
                seminar.ConfrenceRome = _dbContext.ConfrenceRomes.FirstOrDefault(p => p.Id == seminar.ConfrenceRome.Id);

                var result = _dbContext.Seminars.Add(seminar);
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
