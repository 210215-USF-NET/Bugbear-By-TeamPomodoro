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
        //[HttpGet("{name}")]
        //public async Task<IActionResult> GetItemByNameAsync(string name)
        //{
        //    var item = await _bugbearBL.GetItemByNameAsync(name);
        //    if (item == null) return NotFound();
        //    return Ok(item);
        //}

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
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateItemAsync(int id, [FromBody] Item item)
        //{
        //    try
        //    {
        //        await _bugbearBL.UpdateItemAsync(item);
        //        return NoContent();
        //    }
        //    catch
        //    {
        //        return StatusCode(500);
        //    }
        //}

        // DELETE api/<ItemController>/5
        [HttpDelete("{item}")]
        public async Task<IActionResult> DeleteItemAsync(Item item)
        {
            try
            {
                await _bugbearBL.DeleteItemAsync(item);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
