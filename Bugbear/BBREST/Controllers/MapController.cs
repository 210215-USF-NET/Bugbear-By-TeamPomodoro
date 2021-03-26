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

        // GET api/<MapController>/5
        //[HttpGet("{name}")]
        //public async Task<IActionResult> GetMapByNameAsync(string name)
        //{
        //    var map = await _bugbearBL.GetMapByNameAsync(name);
        //    if (map == null) return NotFound();
        //    return Ok(map);
        //}

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

        // PUT api/<MapController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateMapAsync(int id, [FromBody] Map map)
        //{
        //    try
        //    {
        //        await _bugbearBL.UpdateMapAsync(map);
        //        return NoContent();
        //    }
        //    catch
        //    {
        //        return StatusCode(500);
        //    }
        //}

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
