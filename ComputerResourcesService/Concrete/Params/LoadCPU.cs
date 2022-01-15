using ComputerResourcesService.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesService.Concrete.Params
{
    class LoadCPU : BaseParam
    {
        public LoadCPU(float? value)
        {
            SetValue(value);
        }

        public override string GetParamName()
        {
            return "Загрузка процессора";
        }

        public override object GetValue()
        {
            return (float?)Value;
        }

        public override void SetValue(object value)
        {
            Value = value;
        }

        public override string ToString()
        {
            return "cpu_load: " + GetValue();
        }
    }
}
