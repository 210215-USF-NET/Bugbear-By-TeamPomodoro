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
    public class NPCController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public NPCController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }
        // GET: api/<NPCController>
        [HttpGet]
        public async Task<IActionResult> GetNPCsAsync()
        {
            return Ok(await _bugbearBL.GetNPCAsync());
        }

        // GET api/<NPCController>/5
        //[HttpGet("{name}")]
        //public async Task<IActionResult> GetNPCByNameAsync(string name)
        //{
        //    var npc = await _bugbearBL.GetNPCByNameAsync(name);
        //    if (npc == null) return NotFound();
        //    return Ok(npc);
        //}

        // POST api/<NPCController>
        [HttpPost]
        public async Task<IActionResult> AddANPCAsync([FromBody] NPC npc)
        {
            try
            {
                await _bugbearBL.AddNPCAsync(npc);
                return CreatedAtAction("AddANPC", npc);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<NPCController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateNPCAsync(int id, [FromBody] NPC npc)
        //{
        //    try
        //    {
        //        await _bugbearBL.UpdateNPCAsync(npc);
        //        return NoContent();
        //    }
        //    catch
        //    {
        //        return StatusCode(500);
        //    }
        //}

        // DELETE api/<NPCController>/5
        [HttpDelete("{npc}")]
        public async Task<IActionResult> DeleteNPCAsync(NPC npc)
        {
            try
            {
                await _bugbearBL.DeleteNPCAsync(npc);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
