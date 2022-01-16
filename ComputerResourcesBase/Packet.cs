using ComputerResourcesBase.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesBase
{
    public class Packet
    {
        public Packet()
        {

        }

        public Packet(IParam param)
        {
            MachineName = Environment.MachineName;
            MessageId = Guid.NewGuid().ToString("N");
            ParamCode = param.GetParamCode();
            ParamValue = param.GetValue().ToString();
            Date = DateTime.Now;
        }

        public string MachineName { get; set; }
        public string MessageId { get; set; }
        public string ParamCode { get; set; }
        public string ParamValue { get; set; }
        public DateTime Date { get; set; }
    }
}
