﻿using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace PozorWithBlazor.Server.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string userName, string message)
            => await Clients.All.SendAsync("ReceiveMessage", userName, message);
    }
}
