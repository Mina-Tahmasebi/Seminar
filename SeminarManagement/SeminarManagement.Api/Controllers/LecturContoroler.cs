using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeminarManagement.Database.EFCore;
using SeminarMnagamenet.Models;

namespace SeminarManagement.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class LecturContoroler : Controller
    {
        private AppDbContext _dbContext;

        public LecturContoroler(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var result = _dbContext.Lecturs.ToList();

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
                var result = _dbContext.Lecturs.FirstOrDefault(p => p.Id == id);

                return Ok(result);
            }
            catch
            {
                return StatusCode(505);
            }
        }

        [HttpPost]
        public IActionResult Add([FromBody] Lectur lectur)
        {
            try
            {
                lectur.Id = Guid.NewGuid();
                lectur.Seminar= _dbContext.Seminars.FirstOrDefault(p => p.Id == lectur.Seminar.Id);
                var result = _dbContext.Lecturs.Add(lectur);
                _dbContext.SaveChanges();

                return Ok(result);
            }
            catch
            {
                return StatusCode(505);
            }
        }

        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            try
            {
                var lectur = _dbContext.Lecturs.FirstOrDefault(p => p.Id == id);
                _dbContext.Lecturs.Remove(lectur);

                _dbContext.SaveChanges();

                return Ok();
            }
            catch
            {
                return StatusCode(505);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] Lectur lectur)
        {
            try
            {
                var currentEntity = _dbContext.Lecturs.FirstOrDefault(p => p.Id == lectur.Id);

                currentEntity.Topic = lectur.Topic;
                currentEntity.Lecturer = lectur.Lecturer;
                currentEntity.StartAt = lectur.StartAt;
                currentEntity.EndAt = lectur.EndAt;
                currentEntity.Seminar = lectur.Seminar;
                _dbContext.Lecturs.Update(currentEntity);
                _dbContext.SaveChanges();

                return Ok();
            }
            catch
            {
                return StatusCode(505);
            }
        }

    }
}
