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
    public class EncounterController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public EncounterController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }
        // GET: api/<EncounterController>
        [HttpGet]
        public async Task<IActionResult> GetEncountersAsync()
        {
            return Ok(await _bugbearBL.GetEncountersAsync());
        }

        // GET api/<EncounterController>/5
        //[HttpGet("{name}")]
        //public async Task<IActionResult> GetEncounterByNameAsync(string name)
        //{
        //    var encounter = await _bugbearBL.GetEncounterByNameAsync(name);
        //    if (encounter == null) return NotFound();
        //    return Ok(encounter);
        //}

        // POST api/<EncounterController>
        [HttpPost]
        public async Task<IActionResult> AddAEncounterAsync([FromBody] Encounter encounter)
        {
            try
            {
                await _bugbearBL.AddEncounterAsync(encounter);
                return CreatedAtAction("AddAEncounter", encounter);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<EncounterController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateEncounterAsync(int id, [FromBody] Encounter encounter)
        //{
        //    try
        //    {
        //        await _bugbearBL.UpdateEncounterAsync(encounter);
        //        return NoContent();
        //    }
        //    catch
        //    {
        //        return StatusCode(500);
        //    }
        //}

        // DELETE api/<EncounterController>/5
        [HttpDelete("{encounter}")]
        public async Task<IActionResult> DeleteEncounterAsync(Encounter encounter)
        {
            try
            {
                await _bugbearBL.DeleteEncounterAsync(encounter);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
