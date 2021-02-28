using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    public class EmployeesController : ApiController
    {
        // hard coding the employee values
        Employee[] employees = new Employee[]
        {
            new Employee {Id = 1, Name = "Sam", Date= DateTime.Parse(DateTime.Today.ToString()), Age = 25},
            new Employee {Id = 2, Name = "Josh", Date= DateTime.Parse(DateTime.Today.ToString()), Age = 45},
        };
        //get all employess method 
        public IEnumerable<Employee> GetAllEmployess()
        {
            return employees;
        }

        //getting employee by id 
        public IHttpActionResult GetEmployee(int id)
        {
            // i dont want it throwing an exception thats the reason for using first or default 
            var employ = employees.FirstOrDefault(emp => emp.Id == id);
            if (employ == null)
            {
                return NotFound();
            }
            return Ok(employ);
        }
    }
}
