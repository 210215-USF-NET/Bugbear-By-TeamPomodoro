using BBREST.Models;
using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BBREST.HubConfig
{
    public class ChatHub : Hub
    {
        public async Task BroadcastChatData(List<ChatModel> data)
        {
            await Clients.All.SendAsync("broadcastchatdata", data);
        }
        public async Task SendMessage1(string user, string message)
        {
            await Clients.All.SendAsync("ReceiveOne", user, message);
        }
    }
}
