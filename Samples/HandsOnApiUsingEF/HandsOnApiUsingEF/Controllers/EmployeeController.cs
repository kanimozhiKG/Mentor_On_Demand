using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HandsOnApiUsingEF.Models;
using HandsOnApiUsingEF.Repository;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace HandsOnApiUsingEF.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        // GET: api/Employee/GetAll
        [HttpGet]
        [Route("GetAll")]
        public List<Employee> Get()
        {
            return _repository.GetAll();
        }

        // GET: api/Employee/5
        [HttpGet("{id}", Name = "Get")]
        [Route("GetById/{id}")]
        public Employee Get(int id)
        {
            return _repository.GetById(id);
        }

        // POST: api/Employee
        [HttpPost]
        [Route("Add")]
        public IActionResult Post([FromBody] Employee item)
        {
            _repository.Add(item);
            return Ok("Record Added..");
        }

        // PUT: api/Employee/5
        [HttpPut("{id}")]
        [Route("Update")]
        public void Put(Employee item)
        {
            _repository.Update(item);
        }

        // DELETE: api/Employee/Delete/5
        [HttpDelete("{id}")]
        [Route("Delete/{id}")]
        public void Delete(int id)
        {
            _repository.Delete(id);
        }
    }
}
