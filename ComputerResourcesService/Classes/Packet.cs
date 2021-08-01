using System;
using System.Collections.Generic;
using System.Text;

namespace ComputerResourcesService.Classes
{
    public class Packet
    {
        public Packet(string cpu_load, string cpu_temperature, string storage_load, string storage_space)
        {
            _cpu_load = cpu_load;
            _cpu_temperature = cpu_temperature;
            _storage_load = storage_load;
            _storage_space = storage_space;
        }
        private string _cpu_load { get; set; }
        private string _cpu_temperature { get; set; }
        private string _storage_load { get; set; }
        private string _storage_space { get; set; }

        public override string ToString()
        {
            return "{" +
                        $"cpu_load: '{_cpu_load}';" +
                        $"_cpu_temperature: '{_cpu_temperature}';" +
                        $"_storage_load: '{_storage_load}';" +
                        $"_storage_space: '{_storage_space}';" +
                    "}";
        }
    }
}
