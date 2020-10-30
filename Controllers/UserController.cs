using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EzSign.Interface;
using EzSign.Models;

namespace EzSign.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IRepository<ez_emp> _ez_emp;

        public UserController(IRepository<ez_emp> ez_emp)
        {
            _ez_emp = ez_emp;
        }

        [HttpGet]
        public string Get()
        {
            var data = _ez_emp.GetAll();

            return "read" + data.FirstOrDefault().first_name + data.FirstOrDefault().last_name;
        }

        [HttpPost]
        public string Post()
        {
            return "create";
        }

        [HttpPut]
        public string Put()
        {
            return "update";
        }

        [HttpDelete]
        public string Delete()
        {
            return "delete";
        }
    }
}
