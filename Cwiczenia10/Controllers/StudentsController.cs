using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cwiczenia10.Models;
using Cwiczenia10.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Cwiczenia10.Controllers
{
    [Route("api/students")]
    [ApiController]
    public class StudentsController : ControllerBase
    {

        private s16878Context _context;
        public StudentsController(s16878Context context)
        {
            _context = context;
        }
     
        /*
        [HttpGet]
        public IActionResult GetStudents()
        {
            var list = _context.Student.Where(s => s.FirstName != null).ToList();
            return Ok(list);
        }
        */
        /*
        [HttpGet("{id}")]

        public IActionResult Update(string id)
        {
            var list = _context.Student.First(s => s.IndexNumber == id);
            list.FirstName = "Adam";
            _context.SaveChanges();
            return Ok("Zaktualizowano");
        }
        */

        [HttpGet("{id}")]

        public IActionResult Delete(string id)
        {
            _context.Remove(_context.Student.Single(s => s.IndexNumber == id));
            _context.SaveChanges();
            return Ok("Usunięto");
        }

    }
}