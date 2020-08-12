using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using EzSign.Models;

namespace EzSign.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly EzSignDBContext _dbContext;

        public UserController(EzSignDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public string Get()
        {
            var data = _dbContext.AccountModel;

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
