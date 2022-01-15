using ComputerResourcesService.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesService.Concrete.Senders
{
    public abstract class BaseSender : IParamSender
    {
        public abstract void Send(IParam param);
    }
}
