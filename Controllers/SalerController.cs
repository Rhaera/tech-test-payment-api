using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using trilha_tech_test_api_tech.Context;
using trilha_tech_test_api_tech.Models;

namespace trilha_tech_test_api_tech.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SalerController: ControllerBase
    {
        private readonly SalerContext Context;

        public SalerController(SalerContext context)
        {
            Context = context;
        }
        [HttpPost("CreateSale")]
        public IActionResult Create(Saler saler)
        {

            if (ModelState.IsValid) {

                if (saler.Status.Equals("Aguardando pagamento...") && saler.IfAny()) {
                
                    Context.Add(saler);
                    Context.SaveChanges();
            
                    return CreatedAtAction(nameof(GetById), new {id = saler.Id}, saler);
                
                } else return NotFound(saler);            
            } else return NotFound(saler);
        }
        [HttpGet("GetById/{id}")]
        public IActionResult GetById(int id)
        {

            var saler = Context.Salers.Find(id);
            
            if (saler == null) return NotFound(); else return Ok(saler);

        }
    }
}
