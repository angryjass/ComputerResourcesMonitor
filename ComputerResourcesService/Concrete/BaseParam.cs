using ComputerResourcesService.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesService.Concrete
{
    public abstract class BaseParam : IParam
    {
        public object Value { get; set; }

        public abstract string GetParamName();

        public abstract object GetValue();

        public abstract void SetValue(object value);
        public abstract override string ToString();
    }
}
