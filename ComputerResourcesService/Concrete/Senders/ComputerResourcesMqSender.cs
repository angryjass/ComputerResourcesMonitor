using ComputerResourcesService.Abstract;
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
            HttpContent httpContent = new StringContent(param.ToString());

            httpClient.PostAsync(ConfigurationManager.ConnectionStrings["API"].ConnectionString, httpContent);
        }
    }
}
