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
    public class CharacterController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public CharacterController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;            
        }
        // GET: api/<CharacterController>
        [HttpGet]
        public async Task<IActionResult> GetCharactersAsync()
        {
            return Ok(await _bugbearBL.GetCharactersAsync());
        }

        // GET api/<CharacterController>/id
        [HttpGet("{id}")]
        [Produces("application/json")]
        public async Task<IActionResult> GetCharacterByIDAsync(int id)
        {
            var character = await _bugbearBL.GetCharacterByIDAsync(id);
            if (character == null) return NotFound();
            return Ok(character);
        }

        // POST api/<CharacterController>
        [HttpPost]
        public async Task<IActionResult> AddACharacterAsync([FromBody] Character character)
        {
            try
            {
                await _bugbearBL.AddCharacterAsync(character);
                return CreatedAtAction("AddACharacter", character);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<CharacterController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateCharacterAsync(int id, [FromBody] Character character)
        {
            try
            {
                await _bugbearBL.UpdateCharacterAsync(character);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<CharacterController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCharacterAsync(int id)
        {
            try
            {
                await _bugbearBL.DeleteCharacterAsync(await _bugbearBL.GetCharacterByIDAsync(id));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
