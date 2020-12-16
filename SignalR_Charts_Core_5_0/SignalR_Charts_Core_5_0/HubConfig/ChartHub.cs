using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;
using SignalR_Charts_Core_5_0.Models;

namespace SignalR_Charts_Core_5_0.HubConfig
{
    public class ChartHub : Hub
    {
        // you can comment all the code here
        // When you click on the frontend UI it we broadCast to any current UI user
        public async Task BroadcastChartData(List<ChartModel> data) =>
            await Clients.All.SendAsync("broadcastchartdata", data);


        public ChartHub()
        {
        }
    }
}
