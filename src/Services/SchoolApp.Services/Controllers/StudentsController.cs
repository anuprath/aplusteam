using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchoolApp.Data;

namespace SchoolApp.Services.Controllers
{
    [Route("api/[controller]")]
    public class StudentsController : Controller
    {
        // GET api/students
        [HttpGet]
        public IEnumerable<Student> Get()
        {
            return null;
        }

        // GET api/students/5
        [HttpGet("{id}")]
        public Student Get(int id)
        {
            return null;
        }

        // POST api/students
        [HttpPost]
        public void Post([FromBody]string value)
        {

        }

        // PUT api/students/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/students/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
