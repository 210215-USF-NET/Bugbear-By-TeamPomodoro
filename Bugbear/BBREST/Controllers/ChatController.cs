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
    public class ChatController : ControllerBase
    {
        private readonly IBugbearBL _bugbearBL;
        public ChatController(IBugbearBL bugbearBL)
        {
            _bugbearBL = bugbearBL;
        }

        // GET api/<ChatController>/5
        //[HttpGet("{UserID}")]
        //[Produces("application/json")]
        //public async Task<IActionResult> GetChatsByUserIDAsync(int userID)
        //{
        //    return Ok(await _bugbearBL.GetChatsByUserIDAsync(userID));
        //}

        // POST api/<ChatController>
        [HttpPost]
        public async Task<IActionResult> AddAChatAsync([FromBody] Chat chat)
        {
            try
            {
                await _bugbearBL.AddChatAsync(chat);
                return CreatedAtAction("AddAChat", chat);
            }
            catch
            {
                return StatusCode(400);
            }
        }
    }
}
