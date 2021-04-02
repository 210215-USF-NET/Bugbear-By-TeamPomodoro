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
