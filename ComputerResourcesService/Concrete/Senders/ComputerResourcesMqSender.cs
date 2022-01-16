using ComputerResourcesBase.Abstract;
using ComputerResourcesBase;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Net.Http;
using System.Text;
namespace ComputerResourcesService.Concrete.Senders
{
    public class ComputerResourcesMqSender : BaseSender
    {
        readonly HttpClient httpClient;
        public ComputerResourcesMqSender()
        {
            httpClient = new HttpClient();
        }
        public override void Send(IParam param)
        {
            var stringContent = JsonConvert.SerializeObject(new Packet(param));
            HttpContent httpContent = new StringContent(stringContent, Encoding.UTF8, "application/json");

            httpClient.PostAsync(ConfigurationManager.ConnectionStrings["CRMQ"].ConnectionString, httpContent);
        }
    }
}
