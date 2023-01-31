using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trilha_tech_test_api_tech.Context;
using trilha_tech_test_api_tech.Models;

namespace trilha_tech_test_api_tech.Controllers
{
    public class SalerController: ControllerBase
    {
        private readonly SalerContext Context;

        public SalerController(SalerContext context)
        {
            Context = context;
        }
        [HttpPost("CreateContact")]
        public IActionResult Create(Saler saler)
        {

            Context.Add(saler);
            Context.SaveChanges();
            return CreatedAtAction(nameof(GetById), new {id = saler.Id}, saler);

        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {

            var saler = Context.Salers.Find(id);
            
            if (saler == null) return NotFound(); else return Ok(saler);

        }
    }
}
