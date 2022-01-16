using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesBase.Abstract
{
    public interface IParam
    {
        public string GetParamName();
        public string GetParamCode();
        public string ToString();
        public object GetValue();
        public void SetValue(object value);

    }
}
