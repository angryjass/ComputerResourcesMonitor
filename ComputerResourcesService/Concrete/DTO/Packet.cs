using ComputerResourcesService.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesService.Concrete.DTO
{
    public class Packet
    {
        public Packet(IParam param)
        {
            MachineName = Environment.MachineName;
            MessageId = new Guid().ToString("N");
            ParamCode = param.GetParamCode();
            ParamValue = param.GetValue().ToString();
        }

        private string MachineName;
        private string MessageId;
        private string ParamCode;
        private string ParamValue;
    }
}
