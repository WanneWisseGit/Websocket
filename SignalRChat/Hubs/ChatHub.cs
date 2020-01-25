using Microsoft.AspNetCore.SignalR;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        
        public async Task SendMessage(string user, string message)
        {
            var a = new List<int>(){1,2,3};
            await Clients.All.SendAsync("ReceiveMessage", user, a);  
        }
    }
}
