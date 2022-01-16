using ComputerResourcesBase.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesService.Concrete.Params
{
    public abstract class BaseParam : IParam
    {
        public object Value { get; set; }
        public abstract string GetParamCode();

        public abstract string GetParamName();

        public abstract object GetValue();

        public abstract void SetValue(object value);
        public abstract override string ToString();
    }
}
