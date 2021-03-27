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
    public class UserController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public UserController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }
        // GET: api/<UserController>
        [HttpGet]
        public async Task<IActionResult> GetUsersAsync()
        {
            return Ok(await _bugbearBL.GetUsersAsync());
        }

        // GET api/<UserController>/5
        [HttpGet("{email}")]
        public async Task<IActionResult> GetUserByEmailAsync(string email)
        {
            var user = await _bugbearBL.GetUserByEmailAsync(email);
            if (user == null) return NotFound();
            return Ok(user);
        }

        // POST api/<UserController>
        [HttpPost]
        public async Task<IActionResult> AddAUserAsync([FromBody] User user)
        {
            try
            {
                await _bugbearBL.AddUserAsync(user);
                return CreatedAtAction("AddAUser", user);
            }
            catch
            {
                return StatusCode(400);
            }
        }

        // PUT api/<UserController>/5
        //[HttpPut("{id}")]
        //public async Task<IActionResult> UpdateUserAsync(int id, [FromBody] User user)
        //{
        //    try
        //    {
        //        await _bugbearBL.UpdateUserAsync(user);
        //        return NoContent();
        //    }
        //    catch
        //    {
        //        return StatusCode(500);
        //    }
        //}

        // DELETE api/<UserController>/5
        [HttpDelete("{user}")]
        public async Task<IActionResult> DeleteUserAsync(User user)
        {
            try
            {
                await _bugbearBL.DeleteUserAsync(user);
                return NoContent();
            }
            catch
            {
                return StatusCode(500);
            }
        }
    }
}
