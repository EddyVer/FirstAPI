using Microsoft.AspNetCore.Mvc;
using MakeAPI.Context;
using MakeAPI.Entities;

namespace MakeAPI.Controllers
{
    [ApiController]
    [Route("/flower")]
     
    public class FlowersController : ControllerBase
    {
        private readonly FlowersContext _context;

        public FlowersController(FlowersContext context)
        {
            _context = context;
        }
        [HttpGet("allflowers")]
       public IActionResult AllFlowers()
       {
          return Ok(_context.List());
       }

       [HttpGet("ById/{id}")]
       public IActionResult GetById(int id)
       {
           return Ok(_context.GetId(id));
       }

       [HttpGet("ByName/{name}")]
       public IActionResult GetByName(string name)
       {
           return Ok(_context.GetName(name));
       }
       
       [HttpGet("ByColor/{color}")]
       public IActionResult GetByColor(string color)
       {
           return Ok(_context.GetColor(color));
       }

       [HttpPost]
       public IActionResult AddFlower([FromBody] Flower flower)
       {
           _context.FlowerAdd(flower);
           return Ok(flower);
       }

       [HttpPut("modif/{id}")]
       public IActionResult ModifFlower(int id, [FromBody] Flower flower)
       {
           _context.FlowerModif(id,flower);
           return Ok();
       }

       [HttpDelete("delete/{id}")]
       public IActionResult DelFlower(int id)
       {
           _context.DeleteFlower(id);
           return Ok();
       }
    }
}