using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using cw11.Models;
using cw11.Services;

namespace cw11.Controllers
{
    [Route("api/people")]
    [ApiController]
    public class PersonsController : ControllerBase
    {
        private readonly IPeopleDbService _context;

        public PersonsController(IPeopleDbService context)
        {
            _context = context;
        }

        [HttpGet]
        public IActionResult GetPeople()
        {
            return Ok(_context.GetPeople());
        }

    }
}