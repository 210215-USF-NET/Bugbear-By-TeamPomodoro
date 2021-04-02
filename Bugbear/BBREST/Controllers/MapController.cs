using BBBL;
using BBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBREST.Controllers
{
    [ExcludeFromCodeCoverage]
    [Route("api/[controller]")]
    [ApiController]
    public class MapController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public MapController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }
        // GET: api/<MapController>
        [HttpGet]
        public async Task<IActionResult> GetMapsAsync()
        {
            return Ok(await _bugbearBL.GetMapAsync());
        }

        //GET: api/<MapController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetMapByIDAsync(int id)
        {
            var story = await _bugbearBL.GetMapByIDAsync(id);
            if (story == null) return NotFound();
            return Ok(story);
        }

        // POST api/<MapController>
        [HttpPost]
        public async Task<IActionResult> AddAMapAsync([FromBody] Map map)
        {
            try
            {
                await _bugbearBL.AddMapAsync(map);
                return CreatedAtAction("AddAMap", map);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // DELETE api/<MapController>/5
        [HttpDelete("{map}")]
        public async Task<IActionResult> DeleteMapAsync(Map map)
        {
            try
            {
                await _bugbearBL.DeleteMapAsync(map);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
