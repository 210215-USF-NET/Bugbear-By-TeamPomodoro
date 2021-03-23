using BBBL;
using BBModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace BBREST.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LocationController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public LocationController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }
        // GET: api/<LocationController>
        [HttpGet]
        public async Task<IActionResult> GetLocationsAsync()
        {
            return Ok(await _bugbearBL.GetLocationsAsync());
        }

        // GET api/<LocationController>/5
        //[HttpGet("{name}")]
        //public async Task<IActionResult> GetLocationByNameAsync(string name)
        //{
        //    var location = await _bugbearBL.GetLocationByNameAsync(name);
        //    if (location == null) return NotFound();
        //    return Ok(location);
        //}

        // POST api/<LocationController>
        [HttpPost]
        public async Task<IActionResult> AddALocationAsync([FromBody] Location location)
        {
            try
            {
                await _bugbearBL.AddLocationAsync(location);
                return CreatedAtAction("AddALocation", location);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<LocationController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateLocationAsync(int id, [FromBody] Location location)
        //{
        //    try
        //    {
        //        await _bugbearBL.UpdateLocationAsync(location);
        //        return NoContent();
        //    }
        //    catch
        //    {
        //        return StatusCode(500);
        //    }
        //}

        // DELETE api/<LocationController>/5
        [HttpDelete("{location}")]
        public async Task<IActionResult> DeleteLocationAsync(Location location)
        {
            try
            {
                await _bugbearBL.DeleteLocationAsync(location);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
