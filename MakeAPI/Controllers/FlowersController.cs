using Microsoft.AspNetCore.Mvc;
using MakeAPI.Context;
using MakeAPI.Dtos;
using MakeAPI.Entities;
using MakeAPI.Extention;

namespace MakeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
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
          return Ok(_context.List().Select(flower => flower.ToFlowerDto()).ToList());
       }

       [HttpGet("ById/{id}")]
       public IActionResult GetById(int id)
       {
           return Ok(_context.GetId(id).ToFlowerDto());
       }

       [HttpGet("ByName/{name}")]
       public IActionResult GetByName(string name)
       {
           return Ok(_context.GetName(name).ToFlowerDto());
       }
       
       [HttpGet("ByColor/{color}")]
       public IActionResult GetByColor(string color)
       {
           return Ok(_context.GetColor(color).ToFlowerDto());
       }

        [HttpPost("NewFlower")]
        public IActionResult AddFlower([FromBody] FlowerDto flowerDto)
        {
            Flower flower = flowerDto.ToFlower();
            _context.FlowerAdd(flower);
            return Ok(flower);
        }

        [HttpPut("modif/{id}")]
       public IActionResult ModifFlower(int id, [FromBody] FlowerDto flowerDto)
       {
            Flower flower = flowerDto.ToFlower();
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