using BBBL;
using BBModels;
using BBREST.DataStorage;
using BBREST.HubConfig;
using BBREST.Models;
using BBREST.TimerFeatures;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
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
        public readonly IHubContext<ChatHub> _hub;

        public ChatController(IHubContext<ChatHub> hub)
        {
            _hub = hub;
        }
        public IActionResult Get()
        {
            var timerManager = new TimerManager(() => _hub.Clients.All.SendAsync("transferchatdata", DataManager.GetData()));
            return Ok(new { Message = "Request Completed." });
        }

        [Route("send")]                                           //path looks like this: https://localhost:44379/api/chat/send
        [HttpPost]
        public IActionResult SendRequest([FromBody] ChatModel msg)
        {
            _hub.Clients.All.SendAsync("ReceiveOne", msg.UserEmail, msg.Message);
            return Ok();
        }
    }
}
