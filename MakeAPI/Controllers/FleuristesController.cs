using MakeAPI.Context;
using Microsoft.AspNetCore.Mvc;
using MakeAPI.Dtos;
using MakeAPI.Entities;
using MakeAPI.Extention;

namespace MakeAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class FleuristesController : ControllerBase
    {
        private readonly FleuristeContext _context;
        public FleuristesController(FleuristeContext context)
        {
            _context = context;
        }
        [HttpGet("allFleuriste")]
        public IActionResult AllFleuriste()
        {
            return Ok(_context.List().Select(fleuriste => fleuriste.ToFleuristeDto()).ToList());
        }

        [HttpPost("AddFleuriste")]
        public IActionResult AddFleuriste([FromBody] FleuristeDto fleuristeDto)
        {
            Fleuriste fleuriste = fleuristeDto.ToFleuriste();
            _context.FleuristeAdd(fleuriste);
            return Ok(fleuriste);
        }

        [HttpPut("FleuristeModif/{id}")]
        public IActionResult ModifFleuriste(int id, [FromBody] FleuristeDto fleuristeDto)
        {
            Fleuriste fleuriste = fleuristeDto.ToFleuriste();
            _context.FleuristeModif(id, fleuriste);
            return Ok(fleuriste);
        }
    }
}
