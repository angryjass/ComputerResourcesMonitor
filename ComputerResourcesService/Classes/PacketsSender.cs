using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;

namespace ComputerResourcesService.Classes
{
    public static class PacketsSender
    {
        public static void Send(Packet packet)
        {
            HttpClient httpClient = new HttpClient();
            HttpContent httpContent = new StringContent(packet.ToString());

            httpClient.PostAsync(ConfigurationManager.ConnectionStrings["API"].ConnectionString, httpContent);
        }
    }
}
