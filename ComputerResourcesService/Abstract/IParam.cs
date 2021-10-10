using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesService.Abstract
{
    public interface IParam
    {
        public string GetParamName();
        public string ToString();
        public object GetValue();
        public void SetValue(object value);

    }
}
