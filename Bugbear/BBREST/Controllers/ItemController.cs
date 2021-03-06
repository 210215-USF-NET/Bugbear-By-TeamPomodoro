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
    public class ItemController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public ItemController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }
        // GET: api/<ItemController>
        [HttpGet]
        public async Task<IActionResult> GetItemsAsync()
        {
            return Ok(await _bugbearBL.GetItemsAsync());
        }

        // GET api/<ItemController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetItemByIDAsync(int id)
        {
            var item = await _bugbearBL.GetItemByIDAsync(id);
            if (item == null) return NotFound();
            return Ok(item);
        }

        // POST api/<ItemController>
        [HttpPost]
        public async Task<IActionResult> AddAItemAsync([FromBody] Item item)
        {
            try
            {
                await _bugbearBL.AddItemAsync(item);
                return CreatedAtAction("AddAItem", item);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<ItemController>/5
        [HttpPut("{id}")]
        public async Task<IActionResult> UpdateItemAsync(int id, [FromBody] Item item)
        {
            try
            {
                await _bugbearBL.UpdateItemAsync(item);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }

        // DELETE api/<ItemController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteItemAsync(int id)
        {
            try
            {
                await _bugbearBL.DeleteItemAsync(await _bugbearBL.GetItemByIDAsync(id));
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
